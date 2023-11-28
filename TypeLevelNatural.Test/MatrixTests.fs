namespace TypeLevelNatural

open System.Numerics
open Microsoft.VisualStudio.TestTools.UnitTesting
open FsCheck

module Generator =

    let from<'t> = Arb.from<'t>.Generator   // is there a better way to get this?

module Matrix =

    let arb<'t, 'nRows, 'nCols
        when 't :> INumber<'t>
        and 'nRows :> Natural
        and 'nCols :> Natural> =
        gen {
            let! values =
                Gen.array2DOfDim
                    ('nRows.Size, 'nCols.Size)
                    Generator.from<'t>
            return Matrix<'t, 'nRows, 'nCols>.Init(values)
        } |> Arb.fromGen

    let invert = Matrix.tryInvert >> Option.get

type Matrix3x2 = Matrix<int, Nat3, Nat2>
type Matrix2x3 = Matrix<int, Nat2, Nat3>
type Matrix2x2 = Matrix<int, Nat2, Nat2>
type Matrix3x3 = Matrix<int, Nat3, Nat3>

type InvertibleMatrix = Invertible of Matrix<BigRational, Nat2, Nat2>

module InvertibleMatrix =

    let arb =
        gen {
            let! a, b, c, d =
                Generator.from<BigRational>
                    |> Gen.four 
                    |> Gen.where (fun (a, b, c, d) ->
                        a * d - b * c <> BigRational(0))
            return
                Matrix<BigRational, Nat2, Nat2>.Init [|
                    [| a; b |]; [| c; d |]
                |] |> Invertible
        } |> Arb.fromGen

module BigRational =

    let arb =
        gen {
            let! num = Generator.from<int>
            let! den = Generator.from<NonZeroInt>
            return BigRational(num) / BigRational(den.Get)
        } |> Arb.fromGen

type Arbitraries =
    static member Matrix3x2() = Matrix.arb<int, Nat3, Nat2>
    static member Matrix2x3() = Matrix.arb<int, Nat2, Nat3>
    static member Matrix2x2() = Matrix.arb<int, Nat2, Nat2>
    static member Matrix3x3() = Matrix.arb<int, Nat3, Nat3>
    static member InvertibleMatrix = InvertibleMatrix.arb
    static member BigRational = BigRational.arb

/// https://www.cliffsnotes.com/study-guides/algebra/linear-algebra/matrix-algebra/operations-with-matrices
[<TestClass>]
type MatrixTests() =

    let config =
        { Config.QuickThrowOnFailure with
            Arbitrary = [ typeof<Arbitraries> ]
            MaxTest = 1000
            Replay = Some (Random.StdGen (0, 0)) }

    [<TestMethod>]
    member _.Example9() =

        let a =
            Matrix<_, Nat2, Nat3>.Init [|
                [|  1;  0; -3 |]
                [| -2;  4;  1 |]
            |]
        let b =
            Matrix<_, Nat3, Nat2>.Init [|
                [|  2; -1 |]
                [|  3;  0 |]
                [| -5;  2 |]
            |]

        let ab =
            Matrix<_, Nat2, Nat2>.Init [|
                [| 17; -7 |]
                [|  3;  4 |]
            |]
        Assert.AreEqual<_>(ab, a * b)

        let ba =
            Matrix<_, Nat3, Nat3>.Init [|
                [|  4; -4; -7 |]
                [|  3;  0; -9 |]
                [| -9;  8; 17 |]
            |]
        Assert.AreEqual<_>(ba, b * a)

    [<TestMethod>]
    member _.Example18() =
        let a =
            Matrix<_, Nat2, Nat2>.Init [|
                [|  2;  3 |]
                [|  5;  8 |]
            |]
        let aInv =
            Matrix<_, Nat2, Nat2>.Init [|
                [|  8; -3 |]
                [| -5;  2 |]
            |]
        Assert.AreEqual<_>(Some aInv, Matrix.tryInvert a)
        Assert.AreEqual<_>(Matrix.One, a * aInv)
        Assert.AreEqual<_>(Matrix.One, aInv * a)

    [<TestMethod>]
    member _.Example18Float() =
        let a =
            Matrix<_, Nat2, Nat2>.Init [|
                [|  2.;  3. |]
                [|  5.;  8. |]
            |]
        let aInv =
            Matrix<_, Nat2, Nat2>.Init [|
                [|  8.; -3. |]
                [| -5.;  2. |]
            |]
        Assert.AreEqual<_>(Some aInv, Matrix.tryInvert a)
        Assert.AreEqual<_>(Matrix.One, a * aInv)
        Assert.AreEqual<_>(Matrix.One, aInv * a)

    /// https://t-redactyl.io/blog/2020/06/working-with-matrices-powers-and-transposition.html
    [<TestMethod>]
    member _.Power() =
        let a =
            Matrix<_, Nat2, Nat2>.Init [|
                [| 4; 3 |]
                [| 6; 5 |]
            |]
        let a5 =
            Matrix<_, Nat2, Nat2>.Init [|
                [| 22930; 18237 |]
                [| 36474; 29009 |]
            |]
        Assert.AreEqual<_>(a5, a ** 5)

    [<TestMethod>]
    member _.TransposeTwiceIsOriginal() =
        let property (matrix : Matrix3x2) =
            matrix.Transpose().Transpose() = matrix
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditionCommutes() =
        let property (a : Matrix3x2) (b : Matrix3x2) =
            a + b = b + a
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditionAssociates() =
        let property (a : Matrix3x2) (b : Matrix3x2) (c : Matrix3x2) =
            (a + b) + c = a + (b + c)
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditiveIdentity() =
        let property (a : Matrix3x2) =
            a + Matrix.Zero = a
                && Matrix.Zero + a = a
                && a - a = Matrix.Zero
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditionTranspose() =
        let property (a : Matrix3x2) (b : Matrix3x2) =
            (a + b).Transpose() = a.Transpose() + b.Transpose()
        Check.One(config, property)

    [<TestMethod>]
    member _.MultiplicationDistributes() =

        let property1 (a : Matrix3x2) (b : Matrix3x2) (c : Matrix2x3) =
            (a + b) * c = (a * c) + (b * c)
        Check.One(config, property1)

        let property2 (a : Matrix2x3) (b : Matrix3x2) (c : Matrix3x2) =
            a * (b + c) = (a * b) + (a * c)
        Check.One(config, property2)

    [<TestMethod>]
    member _.MultiplicationAssociates() =
        let property (a : Matrix3x2) (b : Matrix2x3) (c : Matrix3x3) =
            (a * b) * c = a * (b * c)
        Check.One(config, property)

    [<TestMethod>]
    member _.MultiplicativeIdentities() =
        let property (a : Matrix2x2) =
            (Matrix.Zero : Matrix2x2) * a = Matrix.Zero
                && (Matrix.One : Matrix2x2) * a = a
        Check.One(config, property)

    [<TestMethod>]
    member _.MultiplicationTranspose() =
        let property (a : Matrix3x2) (b : Matrix2x3) =
            (a * b).Transpose() = b.Transpose() * a.Transpose()
        Check.One(config, property)

    [<TestMethod>]
    member _.InvertTwiceIsOriginal() =
        let property (Invertible a) =
            a |> Matrix.invert |> Matrix.invert = a
        Check.One(config, property)

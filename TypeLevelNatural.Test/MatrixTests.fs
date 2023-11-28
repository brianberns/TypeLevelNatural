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

type Arbitraries =
    static member Matrix3x2() = Matrix.arb<int, Nat3, Nat2>

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
        let property (matrix : Matrix<int, Nat3, Nat2>) =
            matrix.Transpose().Transpose() = matrix
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditionCommutes() =
        let property (a : Matrix<int, Nat3, Nat2>) (b : Matrix<int, Nat3, Nat2>) =
            a + b = b + a
        Check.One(config, property)

    [<TestMethod>]
    member _.AdditionIsTransitive() =
        let property (a : Matrix<int, Nat3, Nat2>) (b : Matrix<int, Nat3, Nat2>) (c : Matrix<int, Nat3, Nat2>) =
            (a + b) + c = a + (b + c)
        Check.One(config, property)

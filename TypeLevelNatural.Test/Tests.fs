namespace TypeLevelNatural

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

/// https://www.cliffsnotes.com/study-guides/algebra/linear-algebra/matrix-algebra/operations-with-matrices
[<TestClass>]
type TestClass() =

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

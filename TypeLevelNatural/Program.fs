namespace TypeLevelNatural

module Program =

    let a =
        let a =
            [|
                [|  1;  0; -3 |]
                [| -2;  4;  1 |]
            |]
        Matrix<_, Nat2, Nat3>.Init(fun iRow iCol -> a[iRow][iCol])
    let b =
        let b =
            [|
                [|  2; -1 |]
                [|  3;  0 |]
                [| -5;  2 |]
            |]
        Matrix<_, Nat3, Nat2>.Init(fun iRow iCol -> b[iRow][iCol])
    printfn "%A" (a * b)

    let m = Matrix<int, Nat3, Nat2>.Init (fun iRow iCol -> iRow + iCol)
    printfn "%A" m

    let m' = m + m
    printfn "%A" m'

namespace TypeLevelNatural

module Program =

    /// https://www.cliffsnotes.com/study-guides/algebra/linear-algebra/matrix-algebra/operations-with-matrices
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
    printfn "%A" (a * b)

    let c =
        Matrix<_, Nat2, Nat2>.Init [|
            [|  1.0;  -1.0 |]
            [|  1.0;   2.0 |]
        |]
    Matrix.tryInvert c
        |> Option.map (fun c' -> 3.0 * c')
        |> printfn "%A"

    /// https://t-redactyl.io/blog/2020/06/working-with-matrices-powers-and-transposition.html
    let d =
        Matrix<_, Nat2, Nat2>.Init [|
            [| 4; 3 |]
            [| 6; 5 |]
        |]
    d ** 5 |> printfn "%A"

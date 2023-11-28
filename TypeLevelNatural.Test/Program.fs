namespace TypeLevelNatural

module Program =

    /// https://t-redactyl.io/blog/2020/06/working-with-matrices-powers-and-transposition.html
    let d =
        Matrix<_, Nat2, Nat2>.Init [|
            [| 4; 3 |]
            [| 6; 5 |]
        |]
    d ** 5 |> printfn "%A"

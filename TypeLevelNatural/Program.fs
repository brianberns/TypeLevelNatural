namespace TypeLevelNatural

module Program =

    let m = Matrix<int, Nat3, Nat2>.Init (fun iRow iCol -> iRow + iCol)
    printfn "%A" m

    let m' = m + m
    printfn "%A" m'

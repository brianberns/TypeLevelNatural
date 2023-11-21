namespace TypeLevelNatural

module Program =

    let m = Matrix.init<int, Nat3, Nat2> (fun iRow iCol -> iRow + iCol)
    printfn "%A" m

    let m' = Matrix.transpose m
    printfn "%A" m'

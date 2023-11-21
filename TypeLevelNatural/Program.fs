namespace TypeLevelNatural

module Program =

    let m = Matrix.zeroCreate<int, Nat3, Nat2>
    printfn "%A" (Matrix.transpose m)

namespace TypeLevelNatural

module Program =

    let v = Matrix.zeroCreate<int, Nat1200, Nat1200>
    printfn "%A" v

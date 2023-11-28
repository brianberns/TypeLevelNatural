namespace TypeLevelNatural

module Program =

    let matrix3x2 = Matrix<int, Nat3, Nat2>.Init(+)
    printfn $"{matrix3x2}"

    let matrix2x4 = Matrix<int, Nat2, Nat4>.Init(+)
    printfn $"{matrix2x4}"

    printfn $"{(matrix3x2 * matrix2x4)}"
    // printfn $"{(matrix2x4 * matrix3x2)}"

namespace TypeLevelNatural

type Matrix<'t, 'nRows, 'nCols when 'nRows :> Natural and 'nCols :> Natural> =
    private MkMatrix of 't[,]

module Matrix =

    let zeroCreate<'t, 'nRows, 'nCols when 'nRows :> Natural and 'nCols :> Natural> : Matrix<'t, 'nRows, 'nCols> =
        Array2D.zeroCreate<'t> 'nRows.Size 'nCols.Size
            |> MkMatrix

    let init<'t, 'nRows, 'nCols when 'nRows :> Natural and 'nCols :> Natural> initializer : Matrix<'t, 'nRows, 'nCols> =
        Array2D.init<'t> 'nRows.Size 'nCols.Size initializer
            |> MkMatrix

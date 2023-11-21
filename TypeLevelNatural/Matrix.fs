namespace TypeLevelNatural

open System.Numerics

type Matrix<'t, 'nRows, 'nCols
    when 't :> INumber<'t>
    and 'nRows :> Natural
    and 'nCols :> Natural> =
    private MkMatrix of 't[,] with

    member matrix.Item
        with get(iRow, iCol) =
            let (MkMatrix values) = matrix
            values[iRow, iCol]

module Matrix =

    let zeroCreate<'t, 'nRows, 'nCols
        when 't :> INumber<'t>
        and 'nRows :> Natural
        and 'nCols :> Natural>
            : Matrix<'t, 'nRows, 'nCols> =
        Array2D.zeroCreate<'t> 'nRows.Size 'nCols.Size
            |> MkMatrix

    let init<'t, 'nRows, 'nCols
        when 't :> INumber<'t>
        and 'nRows :> Natural
        and 'nCols :> Natural> initializer
            : Matrix<'t, 'nRows, 'nCols> =
        Array2D.init<'t> 'nRows.Size 'nCols.Size initializer
            |> MkMatrix

    let transpose<'t, 'nRows, 'nCols
        when 't :> INumber<'t>
        and 'nRows :> Natural
        and 'nCols :> Natural> (matrix : Matrix<'t, 'nRows, 'nCols>)
            : Matrix<'t, 'nCols, 'nRows> =
        init (fun iRow iCol -> matrix[iCol, iRow])

type Matrix<'t, 'nRows, 'nCols
    when 't :> INumber<'t>
    and 'nRows :> Natural
    and 'nCols :> Natural> with

    static member (+)(a : Matrix<'t, 'nRows, 'nCols>, b : Matrix<'t, 'nRows, 'nCols>)
        : Matrix<'t, 'nRows, 'nCols> =
        Matrix.init (fun iRow iCol ->
            a[iRow, iCol] + b[iRow, iCol])

    static member (-)(a : Matrix<'t, 'nRows, 'nCols>, b : Matrix<'t, 'nRows, 'nCols>)
        : Matrix<'t, 'nRows, 'nCols> =
        Matrix.init (fun iRow iCol ->
            a[iRow, iCol] - b[iRow, iCol])

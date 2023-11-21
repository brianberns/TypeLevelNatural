namespace TypeLevelNatural

open System.Numerics

type Matrix<'t, 'nRows, 'nCols
    when 't :> INumber<'t>
    and 'nRows :> Natural
    and 'nCols :> Natural> =
    private { Values : 't[,] }

    member matrix.Item
        with get(iRow, iCol) =
            matrix.Values[iRow, iCol]

    static member private Create(values) : Matrix<'t, 'nRows, 'nCols> =
        { Values = values }

    static member ZeroCreate() =
        Array2D.zeroCreate<'t> 'nRows.Size 'nCols.Size
            |> Matrix<'t, 'nRows, 'nCols>.Create

    static member Init(initializer) =
        Array2D.init<'t> 'nRows.Size 'nCols.Size initializer
            |> Matrix<'t, 'nRows, 'nCols>.Create

    member matrix.Transpose() =
        Matrix<'t, 'nCols, 'nRows>.Init(fun iRow iCol -> matrix[iCol, iRow])

    static member (+)(
        a : Matrix<'t, 'nRows, 'nCols>,
        b : Matrix<'t, 'nRows, 'nCols>) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            a[iRow, iCol] + b[iRow, iCol])

    static member (-)(
        a : Matrix<'t, 'nRows, 'nCols>,
        b : Matrix<'t, 'nRows, 'nCols>) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            a[iRow, iCol] - b[iRow, iCol])

    static member (*)(
        n : 't,
        a : Matrix<'t, 'nRows, 'nCols>) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            n * a[iRow, iCol])

    static member (*)(
        a : Matrix<'t, 'nRows, 'nCols>,
        n : 't) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            a[iRow, iCol] * n)

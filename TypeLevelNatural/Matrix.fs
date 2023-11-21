namespace TypeLevelNatural

open System.Numerics

type Matrix<'t, 'nRows, 'nCols
    when 't :> INumber<'t>
    and 'nRows :> Natural
    and 'nCols :> Natural> =
    private { Values : 't[,] }

    static member private Create(values) : Matrix<'t, 'nRows, 'nCols> =
        { Values = values }

    static member ZeroCreate() =
        Array2D.zeroCreate<'t> 'nRows.Size 'nCols.Size
            |> Matrix<'t, 'nRows, 'nCols>.Create

    static member Init(initializer) =
        Array2D.init<'t> 'nRows.Size 'nCols.Size initializer
            |> Matrix<'t, 'nRows, 'nCols>.Create

    member matrix.Item
        with get(iRow, iCol) =
            matrix.Values[iRow, iCol]

    member matrix.Row(iRow) =
        Vector<'t, 'nCols>.Init(fun iCol ->
            matrix[iRow, iCol])

    member matrix.Column(iCol) =
        Vector<'t, 'nRows>.Init(fun iRow ->
            matrix[iRow, iCol])

    member matrix.Transpose() =
        Matrix<'t, 'nCols, 'nRows>.Init(fun iRow iCol ->
            matrix[iCol, iRow])

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

    static member (*)(
        a : Matrix<'t, 'm, 'p>,
        b : Matrix<'t, 'p, 'n>) =
        Matrix<'t, 'm, 'n>.Init(fun iRow iCol ->
            let row = a.Row(iRow)
            let col = b.Column(iCol)
            row * col)

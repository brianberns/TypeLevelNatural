﻿namespace TypeLevelNatural

open System.Numerics

/// Matrix type with compile-time size.
/// https://ee263.stanford.edu/notes/matrix-primer-lect2.pdf
type Matrix<'t, 'nRows, 'nCols
    when 't :> INumber<'t>
    and 'nRows :> Natural
    and 'nCols :> Natural> =
    private { Values : 't[,] }

    static member private Create(values) : Matrix<'t, 'nRows, 'nCols> =
        { Values = values }

    static member Init(initializer) =
        Array2D.init<'t> 'nRows.Size 'nCols.Size initializer
            |> Matrix<'t, 'nRows, 'nCols>.Create

    static member Init(values : 't[][]) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            values[iRow][iCol])

    static member Init(values : 't[,]) =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            values[iRow, iCol])

    static member Zero =
        Array2D.zeroCreate<'t> 'nRows.Size 'nCols.Size
            |> Matrix<'t, 'nRows, 'nCols>.Create

    static member One =
        Matrix<'t, 'nRows, 'nCols>.Init(fun iRow iCol ->
            if iRow = iCol then 't.One else 't.Zero)

    static member Identity = Matrix<'t, 'nRows, 'nCols>.One

    member matrix.Item
        with get(iRow, iCol) =
            matrix.Values[iRow, iCol]

    member matrix.Row(iRow) =
        Vector<'t, 'nCols>.Init(fun iCol ->
            matrix[iRow, iCol])

    member matrix.Column(iCol) =
        Vector<'t, 'nRows>.Init(fun iRow ->
            matrix[iRow, iCol])

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

    static member (*)(
        a : Matrix<'t, 'nRows, 'nCols>,
        b : Vector<'t, 'nCols>) : Vector<'t, 'nRows> =
        Vector<'t, 'nRows>.Init(fun iRow ->
            a.Row(iRow) * b)

    member matrix.Transpose() =
        Matrix<'t, 'nCols, 'nRows>.Init(fun iRow iCol ->
            matrix[iCol, iRow])

    static member Pow(a : Matrix<'t, 'n, 'n>, b : int) =
        (Matrix<'t, 'n, 'n>.One, Seq.replicate b a)
            ||> Seq.fold (*)

module Matrix =

    /// Warning: Doesn't work for integers.
    let inline tryInvert<'t
        when 't :> INumber<'t>
        and 't : equality>
        (matrix : Matrix<'t, Nat2, Nat2>)
        : Option<Matrix<'t, Nat2, Nat2>> =
        let a = matrix[0, 0]
        let b = matrix[0, 1]
        let c = matrix[1, 0]
        let d = matrix[1, 1]
        let den = a * d - b * c
        if den = 't.Zero then
            None
        else
            let m =
                [|
                    [|  d; -b |]
                    [| -c;  a |]
                |] |> Matrix<'t, Nat2, Nat2>.Init
            Matrix<'t, Nat2, Nat2>.(*)('t.One / den, m)    // not sure why explicit member invocation is needed
                |> Some

namespace TypeLevelNatural

type Vector<'t, 'nCols when 'nCols :> Natural> =
    private MkVector of 't[] with
    
    member vector.Item
        with get(i) =
            let (MkVector values) = vector
            values[i]

module Vector =

    let zeroCreate<'t, 'nCols when 'nCols :> Natural> : Vector<'t, 'nCols> =
        Array.zeroCreate<'t> 'nCols.Size
            |> MkVector

    let init<'t, 'nCols when 'nCols :> Natural> initializer : Vector<'t, 'nCols> =
        Array.init<'t> 'nCols.Size initializer
            |> MkVector

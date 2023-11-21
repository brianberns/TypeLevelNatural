namespace TypeLevelNatural

open System.Numerics

type Vector<'t, 'n
    when 't :> INumber<'t>
    and 'n :> Natural> =
    private { Values : 't[] }
    
    member vector.Item
        with get(i) =
            vector.Values[i]

module Vector =

    let private create values =
        { Values = values }

    let zeroCreate<'t, 'n
        when 't :> INumber<'t>
        and 'n :> Natural> : Vector<'t, 'n> =
        Array.zeroCreate<'t> 'n.Size
            |> create

    let init<'t, 'n
        when 't :> INumber<'t>
        and 'n :> Natural> initializer : Vector<'t, 'n> =
        Array.init<'t> 'n.Size initializer
            |> create

type Vector<'t, 'n
    when 't :> INumber<'t>
    and 'n :> Natural> with

    static member (+)(a : Vector<'t, 'n>, b : Vector<'t, 'n>)
        : Vector<'t, 'n> =
        Vector.init (fun i -> a[i] + b[i])

    static member (-)(a : Vector<'t, 'n>, b : Vector<'t, 'n>)
        : Vector<'t, 'n> =
        Vector.init (fun i -> a[i] - b[i])

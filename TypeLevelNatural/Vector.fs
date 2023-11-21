namespace TypeLevelNatural

open System.Numerics

type Vector<'t, 'n
    when 't :> INumber<'t>
    and 'n :> Natural> =
    private { Values : 't[] }
    
    member vector.Item
        with get(i) =
            vector.Values[i]

    static member private Create(values) : Vector<'t, 'n> =
        { Values = values }

    static member ZeroCreate() =
        Array.zeroCreate<'t> 'n.Size
            |> Vector<'t, 'n>.Create

    static member Init(initializer) =
        Array.init<'t> 'n.Size initializer
            |> Vector<'t, 'n>.Create

    static member (+)(a : Vector<'t, 'n>, b : Vector<'t, 'n>) =
        Vector<'t, 'n>.Init (fun i -> a[i] + b[i])

    static member (-)(a : Vector<'t, 'n>, b : Vector<'t, 'n>) =
        Vector<'t, 'n>.Init(fun i -> a[i] - b[i])

    static member (*)(a : Vector<'t, 'n>, b : Vector<'t, 'n>) =
        seq {
            for i =  0 to 'n.Size - 1 do
                a[i] * b[i]
        } |> Seq.sum

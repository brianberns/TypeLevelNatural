﻿namespace TypeLevelNatural

open System.Numerics

type Vector<'t, 'n
    when 't :> INumber<'t>
    and 'n :> Natural> =
    private MkVector of 't[] with
    
    member vector.Item
        with get(i) =
            let (MkVector values) = vector
            values[i]

module Vector =

    let zeroCreate<'t, 'n
        when 't :> INumber<'t>
        and 'n :> Natural> : Vector<'t, 'n> =
        Array.zeroCreate<'t> 'n.Size
            |> MkVector

    let init<'t, 'n
        when 't :> INumber<'t>
        and 'n :> Natural> initializer : Vector<'t, 'n> =
        Array.init<'t> 'n.Size initializer
            |> MkVector

type Vector<'t, 'n
    when 't :> INumber<'t>
    and 'n :> Natural> with

    static member (+)(a : Vector<'t, 'n>, b : Vector<'t, 'n>)
        : Vector<'t, 'n> =
        Vector.init (fun i -> a[i] + b[i])

    static member (-)(a : Vector<'t, 'n>, b : Vector<'t, 'n>)
        : Vector<'t, 'n> =
        Vector.init (fun i -> a[i] - b[i])

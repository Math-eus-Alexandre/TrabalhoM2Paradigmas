let rec verificaEhPrimo numero =
    let rec verificaDivisor numero divisor =
        match divisor with
        | 1 -> true 
        | d when numero % d = 0 -> false
        | d -> verificaDivisor numero (d - 1)

    match numero with
    | n when n <= 1 -> false
    | 2 -> true
    | _ -> verificaDivisor numero (numero - 1)

printfn "%b" (verificaEhPrimo 7)
     
let rec trataValor valor1 valor2 = 
    match valor1 = valor2 with
    | true -> valor1 * valor2
    | false when valor2 > 1 -> valor1 * trataValor valor1 (valor2 - 1)
    | _ -> valor1

printfn "%i" (trataValor 3 2)
let calcMedia nota1 nota2 nota3 =
    (nota1 + nota2 + nota3) / 3.0

let ehMaiorQueMinimo media = 
    media >= 6.0

let dizSeAprovou acimaDoMinimo =
    if acimaDoMinimo then
        printfn "Aprovado"
    else
        printfn "Reprovado"

let readDouble prompt =
    printf "%s" prompt
    System.Console.ReadLine() |> System.Double.Parse

let n1 = readDouble "Digite a nota 1: "
let n2 = readDouble "Digite a nota 2: "
let n3 = readDouble "Digite a nota 3: "

calcMedia n1 n2 n3 |> ehMaiorQueMinimo |> dizSeAprovou
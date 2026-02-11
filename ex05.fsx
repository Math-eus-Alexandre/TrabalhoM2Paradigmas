//Faça uma função que recebe uma lista e retorne o produto dos valores ímpares.

let rec multiplicaImpares lista =
    match lista with
    | [] -> 1
    | head :: tail when head % 2 <> 0 -> head * multiplicaImpares tail
    |_ :: tail -> multiplicaImpares tail

let resultado = multiplicaImpares [0..20]

printfn "%i" resultado


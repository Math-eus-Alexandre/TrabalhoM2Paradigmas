
let pares n = n % 2 = 0
let multiplicaPor2 n = n * 2
let divisivelPor6 n = n % 6 = 0

[0..20] |> List.filter pares |> List.map multiplicaPor2 |> List.filter divisivelPor6
let printTriangulo lado1 lado2 lado3 =
    if lado1 = lado2 && lado2 = lado3 then
        printfn "Triângulo Equilátero"
    elif lado1 = lado2 || lado1 = lado3 || lado2 = lado3 then
        printfn "Triângulo Isósceles"
    elif lado1 > lado2 + lado3 || lado2 > lado1 + lado3 || lado3 > lado1 + lado2 then
        printfn "Não é um triângulo"
    else
        printfn "Triângulo Escaleno"

printTriangulo 3 3 3
printTriangulo 3 2 2
printTriangulo 3 4 5
printTriangulo 1 2 4
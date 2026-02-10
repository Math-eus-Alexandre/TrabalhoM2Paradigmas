let DivisaoMaiorMenor num1 num2 =
    if num1 > num2 then
        num1 / num2
    else
        num2 / num1

printfn "%i" (DivisaoMaiorMenor 10 2)
printfn "%i" (DivisaoMaiorMenor 2 10)
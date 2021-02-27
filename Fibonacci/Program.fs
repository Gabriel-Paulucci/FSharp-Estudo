open System

let scanf pergunta =
    printf "%s: " pergunta
    Console.ReadLine()

let rec fibonacci n =
    match n with
    | n when n <= 2 -> 1
    | _ -> fibonacci (n - 2) + fibonacci (n - 1)

[<EntryPoint>]
let main argv =

    scanf "Numero para a fibonacci"
    |> int32
    |> fibonacci
    |> printf "Resultado %d"

    0 // return an integer exit code

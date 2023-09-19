// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let rec Fib  n =
    match n with
    | 1 | 2 -> 1
    | n -> Fib(n-1) + Fib(n-2)

let x = Fib(24)
printf "%i" x

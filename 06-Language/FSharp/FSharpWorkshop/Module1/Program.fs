// Learn more about F# at http://fsharp.org

open System
open Types
open Functions

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let customer = { Id = 1; IsVip = false; Credit = 10M }
    
    let purchases = (customer, 101M)
    let vipCustomer = tryPromoteToVip purchases

    let calcularePurchases = getPurchases customer
    
    0 // return an integer exit code

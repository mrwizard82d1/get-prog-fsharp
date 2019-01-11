[<EntryPoint>]
let main argv =
    let itemCount = argv.Length
    printfn "Passed %d items into %A." itemCount argv
    0 // return an integer exit code

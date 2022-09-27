// Synchronous flow with "wait"
printfn $"{System.DateTime.UtcNow:``o``} Loading data synchronously!"
System.Threading.Thread.Sleep(5000)
printfn $"{System.DateTime.UtcNow:``o``} Loaded data synchronously!"
printfn $"{System.DateTime.UtcNow:``o``} My synchronous name is Simon."

// Asynchronous flow with "wait"
async {
    printfn $"{System.DateTime.UtcNow:``o``} Loading data asynchronously!"
    System.Threading.Thread.Sleep(5000)
    printfn $"{System.DateTime.UtcNow:``o``} Loaded data asynchronously!"
} |> Async.Start
printfn $"{System.DateTime.UtcNow:``o``} My asynchronous name is Simon."

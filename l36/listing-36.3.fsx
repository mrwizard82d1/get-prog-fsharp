// "Complex" (multiline) code inside an `async` block

open System.Threading

let printThread text =
    printfn $"{System.DateTime.UtcNow:``o``} - THREAD %d{Thread.CurrentThread.ManagedThreadId}: %s{text}"
    
// Simulates long running piece of work.
let doWork () =
    printThread "Starting a long running block"
    Thread.Sleep 5000
    printThread "Finishing a long running block"
    "HELLO"
    
let asyncLength : Async<int> =
    printThread "Creating an `async` block"
    let asyncBlock =
        async {
            // Printing to the console within an `async` block
            printThread "In block!"
            let text = doWork()
            // Returning a number from the `async` block
            return (text + " ASYNC WORLD!").Length
        }
    printThread "Created async block"
    asyncBlock
     
// Unwrapping the `Async<int>`
printThread "Back to the top-level code"

// Remember that **no** work starts until the following line executes
// As a consequence, one can create `async` blocks and pass them around
// your application without any problems. When "the time is right," one
// can execute the block by calling `Async.RunSynchronously`.
let length = asyncLength |> Async.RunSynchronously

[<EntryPoint>]  // The `EntryPoint` attribute identifies the entry point of the entire application
let main args =
    // Print the command line arguments
    printfn $"Console application passed %d{args.Length} command line arguments %A{args}"
    
    // A return value of 0 becomes a success exit code for the process.
    0
    
// Shadowing in FSI

let foo() =
    let x = 10  // Bind `x` for the first time
    printfn $"First: %d{x + 20}"
    
    let x = "test"  // Hide (shadow) previous binding. Only in FSI.
    printfn $"Second: %s{x}"
    
    let x = 50.0  // Hide (shadow) previous binding. Only in FSI.
    printfn $"Third: %f{x + 200.0}"
    x + 200.0
    
foo()
    
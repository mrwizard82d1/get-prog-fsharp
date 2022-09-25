// Scoping in F#

// No accessibility modifier (all top-level values are `public` by default).
// No static modifier (C# requires all functions (lambdas?) to be defined in a class scope).
let doStuffWithTwoNumbers first second =
    let added = first + second
    printfn $"%d{first} + %d{second} = %d{added}"
    let doubled = added * 2
    doubled  // No `return` keyword needed; return last expression of scope
    
doStuffWithTwoNumbers 3 5

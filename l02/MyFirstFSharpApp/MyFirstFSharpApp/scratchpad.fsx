let text = "Hello, F# REPL World!"
text.Length

let greetPerson name age =
    $"Hello, %s{name}. You are %d{age} years old."
let greeting = greetPerson "Fred" 25


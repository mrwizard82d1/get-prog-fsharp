let text = "Hello, F# REPL World!"
text.Length

let greetPerson name age =
    $"Hello, %s{name}. You are %d{age} years old."
let greeting = greetPerson "Fred" 25

let countWords (text:string) =
    Array.length (text.Split ())
let toSplit = "Four score and seven years ago, our fathers brought forth on this continent" +
              " a new nation, conceived in liberty and dedicated to the proposition" +
              " that all men are equal."
let wordCount = countWords toSplit

toSplit
wordCount

System.IO.File.WriteAllText("./word-count.txt", sprintf $"The string, '%s{toSplit}', has %d{wordCount} words.")

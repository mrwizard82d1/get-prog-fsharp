// Define an asynchronous block
// NOTE: the value returned from an `async` block **must** be preceded
// by the `return` keyword
let asyncHello : Async<string> = async { return "Hello" }

// Invoking the `Length` property without running raises an exception
// (Uncomment to see the issue)
// let length = asyncHello.Length

// Wait for the asynchronous block to finish
// Think of `Async.RunSynchronously` as _unwrapping_ an asynchronous value
//
// Additionally, defining an `async` value **does not** start the block.
// Instead, one must execute `Async.RunSynchronously` or `Async.Start`.
//
// Finally, unlike `Task.Result`, every time one invokes `Run.Asynchronously`,
// the `async` block runs **anew**.
let text = asyncHello |> Async.RunSynchronously

// Now I can invoke the `Length` property with no error
let lengthTwo = text.Length

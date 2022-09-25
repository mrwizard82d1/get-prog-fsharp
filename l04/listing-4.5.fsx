// Unmanaged scope

// Even though this block computes the `estimatedAge` message,
// it exposes `year` and `age` publicly.
let year = System.DateTime.Now.Year
let age = year - 1979

// We can do better!
let estimatedAge = sprintf $"You are about %d{age} years old!"  // 

// rest of application

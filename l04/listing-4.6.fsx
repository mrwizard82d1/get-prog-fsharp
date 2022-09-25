// Tightly bound scope

let estimatedAge =
    // THe variable, `age`, is only used to calculate `estimatedAge`
    let age =
        // The variable, `year`, is only used to calculate, `age`
        let year = System.DateTime.Now.Year
        year - 1979
    sprintf $"You are about %d{age} years old!"
    
estimatedAge

// Nested (inner) functions

let estimatedAge familyName year1 year2 year3 =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth
        
    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3
    
    let averageAge = (estimatedAge1 + estimatedAge2 + estimatedAge3) / 3
    sprintf $"Average age for family, %s{familyName}, is %d{averageAge}."
    
estimatedAge "Jones" 1990 1993 1996

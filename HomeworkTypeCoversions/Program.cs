
/*
 * Capture a user's age from the console and
 * then identify how old they will be in 
 * 25 years, as well as how old they were 25 years ago.
 * Print that information to the console in natural language.
 */

// Identify how old is user
Console.Write("How old are you: ");
string? age = Console.ReadLine();

// Add 25 years to the user
int ageAdd = int.Parse(age) + 25;

// Subtract 25 years to the user
int ageSubtract = int.Parse(age) - 25;

// Print all that info to the console
Console.WriteLine($"You are currently {age} years old, you will be {ageAdd} years old in 25 years and you were {ageSubtract} years old 25 years ago!");
// C# from the very beginning!
Console.WriteLine("Hello, World!\n");

// Variable declaration
string whoami = "Nigel The First";
Console.WriteLine(whoami);

whoami = "Just Another Curious Learner";
Console.WriteLine(whoami + Environment.NewLine);
// or just + "\n" to add an EXTRA new line

// String Concatenation
Console.WriteLine("Bonjour, " + whoami);

// Now using string interpolation
Console.WriteLine($"{whoami} using string interpolation!\n");

// The Length property
Console.WriteLine($"The length of {whoami} is {whoami.Length}");

// Trimming strings
string myString = "   This is a string with spaces before and after   ";
// The square brackets are used to visually show start and end of string
Console.WriteLine($"[{myString}]");

// Trim from the start
string trimBeginning = myString.TrimStart();
Console.WriteLine($"[{trimBeginning}]");

// Trim from the end
string trimEnd = myString.TrimEnd();
Console.WriteLine($"[{trimEnd}]");

// Trim from both start and end
string trimBoth = myString.Trim();
Console.WriteLine($"[{trimBoth}]\n");

// Searching for a substring within a string
Console.WriteLine(myString.Contains("before"));
Console.WriteLine($"The word \"before\" occurs in '{myString}' at position {myString.IndexOf("before")}");

// Replacing the word "string" with the word "sentence" in myString
Console.WriteLine(myString.Replace("string", "sentence"));

// Changing CASE
Console.WriteLine(myString.ToUpper());
Console.WriteLine(myString.ToLower());

/* STRINGS ARE IMMUTABALE SO ORIGINAL STRING IS UNCHANGED
 * even after replacing "string" with "sentence"
 * For you to change the original string, you need to reassign the
 * result of the Replace() method to the original string.
 */

// Verify if a string starts with a particular substring
Console.WriteLine(trimBoth.StartsWith("This"));

// Verify if a string ends with a particular substring
Console.WriteLine(trimBoth.EndsWith("after"));

/* If we use myString instead of trimBoth, the result will be false
 * because myString has spaces at the beginning and end.
 * Beware of EndsWith(), if there's a fullstop at the end of the string,
 * include it in the parameter.
 */
namespace AssignmentDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string originalString = "The quick brown fox jumps over the lazy dog";

            // a) Print the character at the 12th index
            Console.WriteLine($"a) Character at index 12: {originalString[12]}");

            // b) Check whether the string contains the word "is"
            Console.WriteLine($"b) Contains the word 'is': {originalString.Contains("is")}");

            // c) Add the string "and killed it" to the existing string
            originalString += " and killed it";
            Console.WriteLine($"c) Modified string: {originalString}");

            // d) Check whether the string ends with the word "dogs"
            Console.WriteLine($"d) Ends with 'dogs': {originalString.EndsWith("dogs")}");

            // e) Check whether the string is equal to "The quick brown Fox jumps over the lazy Dog"
            Console.WriteLine($"e) String equals: {originalString.Equals("The quick brown Fox jumps over the lazy Dog", StringComparison.OrdinalIgnoreCase)}");

            // f) Check whether the string is equal to "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"
            Console.WriteLine($"f) String equals (all uppercase): {originalString.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG")}");

            // g) Find the length of the string
            Console.WriteLine($"g) Length of the string: {originalString.Length}");

            // h) Check whether the string matches "The quick brown Fox jumps over the lazy Dog"
            Console.WriteLine($"h) Matches 'The quick brown Fox jumps over the lazy Dog': {originalString.Equals("The quick brown Fox jumps over the lazy Dog", StringComparison.OrdinalIgnoreCase)}");

            // i) Replace the word "The" with the word "A"
            originalString = originalString.Replace("The", "A");
            Console.WriteLine($"i) String after replacement: {originalString}");

            // j) Split the string to avoid two animal names coming together
            string[] animalNames = originalString.Split(' ');
            Console.WriteLine($"j) String after split: {string.Join(" ", animalNames)}");

            // k) Print animal names alone separately
            Console.WriteLine($"k) Animal names alone: {animalNames[2]}, {animalNames[5]}");

            // l) Print the string in completely lower case
            Console.WriteLine($"l) String in lower case: {originalString.ToLower()}");

            // m) Print the string in completely upper case
            Console.WriteLine($"m) String in upper case: {originalString.ToUpper()}");

            // n) Find the index position of the character "a"
            Console.WriteLine($"n) Index of 'a': {originalString.IndexOf('a')}");

            // o) Find the last index position of the character "e"
            Console.WriteLine($"o) Last index of 'e': {originalString.LastIndexOf('e')}");

            // p) Prompt the user to enter the home directory of Tomcat server
            Console.Write("Enter the home directory of Tomcat server: ");
            string userPath = Console.ReadLine();
            string imagePath = $@"{userPath}\WebApps\MyApps\Images";
            Console.WriteLine($"p) Updated path: {imagePath}");

            // q) Constant string representing poem lines without escape characters
            const string poemLines = @"
I WANDER'D lonely as a cloud
That floats on high o'er vales and hills,

When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.";
            Console.WriteLine($"q) Poem lines: {poemLines}");
        }
    }
}



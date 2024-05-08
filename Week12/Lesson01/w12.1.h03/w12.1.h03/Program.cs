public class Program
{
    public static void Main(string[] args)
    {
        string[] inputStrArr = args[1..^0];
        //Input strings for first test:
        //"racecar", "hello", "level", "A man, a plan, a canal, Panama!";

        foreach (string str in inputStrArr)
        {
            //Make lowercase and remove non-letters
            string cleanedStr = new string(str.ToLower().Where(c => char.IsLetter(c)).ToArray());

            bool isPalindrome = IsPalindrome(cleanedStr);
            Console.WriteLine($"\"{cleanedStr}\" is {(isPalindrome ? "a palindrome" : "not a palindrome")}");
        }
    }


    //Method Palindrome goes here
    public static bool IsPalindrome(string s)
    {
        if (s.Length <= 1)
            return true; // Base case: Empty string or single character is a palindrome

        // Compare the first and last characters
        if (s[0] != s[^1])
            return false;

        // Recur for the substring excluding the first and last characters
        return IsPalindrome(s[1..^1]);
    }
}
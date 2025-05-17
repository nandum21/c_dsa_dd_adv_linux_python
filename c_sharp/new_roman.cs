using System.Linq;
using System;
using System.Collections.Generic;
public class RomanNumeralConverter
{
 public static string IntToRoman(int num) {
    if (num < 1 || num > 3999) {
        return "Invalid Input: Number must be between 1 and 3999.";
    }

    // Define a mapping of Roman numeral symbols to their integer values
    Dictionary<int, string> romanMap = new Dictionary<int, string>() {
        {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
        {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
        {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
    };

    string roman = ""; // Initialize an empty string to hold the Roman numeral

    // Iterate through the mapping in descending order of integer values
    foreach (var kvp in romanMap.OrderByDescending(kvp => kvp.Key)) {
        while (num >= kvp.Key) {
            roman += kvp.Value; // Append the corresponding Roman numeral to the result
            num -= kvp.Key; // Subtract the value from the input number
        }
    }

    return roman;
}

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer to convert to Roman numerals:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            try
            {
                string romanNumeral = IntToRoman(number);
                Console.WriteLine($"The Roman numeral representation of {number} is {romanNumeral}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
   }

}

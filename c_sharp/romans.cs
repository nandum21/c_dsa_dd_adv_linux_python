using System;
using System.Text;

public class RomanNumeralConverter
{
    public static string ToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new ArgumentOutOfRangeException("Input number must be between 1 and 3999.");
        }

        var romanNumerals = new (int value, string symbol)[]
        {
            (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
            (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
            (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
        };

        var result = new StringBuilder();

        foreach (var (value, symbol) in romanNumerals)
        {
            while (number >= value)
            {
                result.Append(symbol);
                number -= value;
            }
        }

        return result.ToString();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer to convert to Roman numerals:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            try
            {
                string romanNumeral = ToRoman(number);
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

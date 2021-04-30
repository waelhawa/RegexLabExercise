using System;
using System.Text.RegularExpressions;

namespace RegexLabExercise
{
    class Program
    {
        const string emailExpression = "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";
        const string nameExpression = "[A-Z][-'a-zA-Z]{3,}";
        const string dateExpression = "^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$";
        const string htmlExpression = "<?([a-z]{1,})>+(()|([A-z]))+<\\/\\1>";
        const string phoneExpression = "\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}";
        static void Main(string[] args)
        {
            Validation("Name", nameExpression);
            Validation("Email", emailExpression);
            Validation("Phone Number", phoneExpression);
            Validation("Date", dateExpression);
            Validation("HTML tag", htmlExpression);
        }

        public static void Validation (string input, string expression)
        {
            string text;

            Console.Write($"Please enter a valid {input}: ");
            text = Console.ReadLine();
            if (Regex.IsMatch(text, expression))
            {
                Console.WriteLine($"{input} is valid");
            }
            else
            {
                Console.WriteLine($"Sorry, {input} is not valid!");
            }

        } //end Validation
    }
}

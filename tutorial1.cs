// --------------------------------------- Exercise --------------------------------------------


//using System;

// namespace program
// {
//     class print
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Welcome to C# Programming!");

//                 //single line comments
//         /*double-line
//             comment*/

//         Console.WriteLine("Hello Comments!");   
//         }
//     }


// }

// namespace tutorial
// {
// class Program
//     {
//         static void Main(string[] args)
//         {
//             // int: Commonly used integer type
//             int book = 25;

//             Console.WriteLine("b: " + book);

//             // long: Used for larger numbers
//             long population = 9876543210;
//             Console.WriteLine("p: " + population);

//             // short: Used for smaller numbers
//             short year = 2024; //4 numbers
//             Console.WriteLine("y: " + year);

//             // byte: Used for very small numbers or binary data
//             byte age = 255; //8 bit interger
//             Console.WriteLine("Level: " + age);
//         }
//     }
// }


// using System;

// namespace TypeConversion
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Explicit conversion from double to int
//             double pi = 3.1415;
//             int intPi = (int)pi; // Cast double to int
//             Console.WriteLine("Explicit Conversion from double to int: " + intPi);

//                         // Implicit conversion from int to double
//             int num = 123;
//             double doubleNum = num;
//             Console.WriteLine("Implicit Conversion from int to double: " + doubleNum);
//         }
//     }
// }


// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 1

// using System;

// namespace tutorial
// {
//     class program
//     {
//         static void Main (string[] args)
//         {
//             string fname, lname;
//             int age, year;

//             Console.WriteLine ("Enter your first name: ");
//             fname = Console.ReadLine();

//             Console.WriteLine ("Enter your last name: ");
//             lname = Console.ReadLine();

//             Console.WriteLine ("Enter your age: ");
//             age = int.Parse(Console.ReadLine());
//         //age = Convert.ToInt23(input);
//         //Console.ReadLine(age);
//         //string ageInput = Console.ReadLine();

//             year = 100 - age;

//             Console.WriteLine ("Hello, " +fname +" " +lname +". You will turn 100 in " +year +" years." );
//         //Console.WriteLine($"Hello, {fname} {lname}. You will turn 100 in {yearsUntil100} years.");

//         }
//     }   
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 2

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string word;

//             Console.WriteLine ("Enter a word: ");
//             word = Console.ReadLine();

//             int length = word.Length;

//             for (int i = 0; i < length; i++)
//             {
//                 Console.WriteLine($"Character {i + 1}: {word[i]}");
//             }
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 3

// using System;

// namespace StringMethods
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string fword;
//             string sword;
            
//             Console.WriteLine("Enter the first string: ");
//             fword = Console.ReadLine();

//             Console.WriteLine("Enter the second string: ");
//             sword = Console.ReadLine();

//             if (string.Equals(fword, sword, StringComparison.OrdinalIgnoreCase))
//             {
//                 Console.WriteLine("The strings are equal.");
//             }
//             else
//             {
//                 Console.WriteLine("The strings are not equal.");
//             }
//         }
//     }
// }


// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 4

// using System;

// namespace CircleCalculations
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             const double Pi = 3.14159;
//             double area, circumference;

//             Console.WriteLine("Enter the radius of the circle: ");
//             if (double.TryParse(Console.ReadLine(), out double radius))
//             {
//                 area = Pi * radius * radius;
//                 circumference = 2 * Pi * radius;

//                 Console.WriteLine($"For a circle with radius {radius}, Area: {area:F2}, Circumference: {circumference:F2}");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid radius entered.");
//             }
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 5

// using System;

// namespace SubstringAndVowelCounting
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string sentence, fword;
//             int vowelCount;

//             Console.WriteLine("Enter a sentence: ");
//             sentence = Console.ReadLine();

//             if (sentence != null)
//             {
//                 fword = sentence.Split(' ')[0];
//                 vowelCount = 0;
//                 foreach (char c in fword.ToLower())
//                 {
//                     if ("aeiou".Contains(c))
//                     {
//                         vowelCount++;
//                     }
//                 }

//                 Console.WriteLine($"The first word is '{fword}', which contains {vowelCount} vowels.");
//             }
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 6

// using System;

// namespace StringReversalAndPalindrome
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string input, reversed;
//             bool isPalindrome;
//             char[] array;

//             Console.WriteLine("Enter a string: ");
//             input = Console.ReadLine();

//             if (input != null)
//             {
//                 reversed = ReverseString(input);
//                 isPalindrome = string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);

//                 Console.WriteLine($"Reversed String: {reversed}");
//                 Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
//             }
//         }

//         static string ReverseString(string s)
//         {
//             char[] array = s.ToCharArray();
//             Array.Reverse(array);
//             return new string(array);
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 7

// using System;

// namespace charfreqcounter
// {
//     class program
//     {
//         static void Main(String [] args)
//         {
//             string word;
//             int freq, countedIndex;

//             Console.WriteLine ("Enter a string: ");
//             word = Console.ReadLine();

//             Console.WriteLine ("Character frequencies: ");

//             char[] countedChars = new char[word.Length];
//             countedIndex = 0;

//             for (int i = 0; i < word.Length; i++)
//             {
//                 char currentChar = word[i];
//                 int count = 0;

//                 bool alreadyCounted = false;
//                 for (int j = 0; j < countedIndex; j++)
//                 {
//                     if (countedChars[j] == currentChar)
//                     {
//                         alreadyCounted = true;
//                         break;
//                     }
//                 }

//             if (!alreadyCounted)
//                 {
//                     for (int k = 0; k < word.Length; k++)
//                     {
//                         if (word[k] == currentChar)
//                         {
//                             count++;
//                         }
//                     }

//                     countedChars[countedIndex] = currentChar;
//                     countedIndex++;

//                     Console.WriteLine($"{currentChar}: {count}");
//                 }
//             }

//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 8

// using System;
// using System.Globalization;

// namespace BirthdateCalculator
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter your birthdate (YYYY-MM-DD): ");
//             DateTime birthdate = DateTime.Parse(Console.ReadLine());

//             int daysLived = (DateTime.Now - birthdate).Days;

//             Console.WriteLine($"You have lived {daysLived} days.");
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 9

// using System;
// using System.Globalization;

// namespace CapitalizeWords
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentence: ");
//             string sentence = Console.ReadLine();
            
//              //Converting to Title Case , ToTitleCase, will cover all the word including the and in

//             TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
//             string capitalizedSentence = textInfo.ToTitleCase(sentence.ToLower());

//             Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 10

// using System;

// namespace stringsplitting
// {
//     class program
//     {
//         static void Main ( String [] args)
//         {
//             Console.WriteLine ("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             string[] words = sentence.Split(' ');

//             Console.WriteLine ($"Number of words {words.Length}");

//             for (int i=0; i<words.Length; i++)
//             {
//                 Console.WriteLine ($"Word {i}: {words[i]}");
//             }
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 14

// using System;
// using System.Collections.Generic;

// namespace LongestWordFinder
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             FindLongestWords(sentence);
//         }

//         static void FindLongestWords(string sentence)
//         {
//             // Logic will be added here
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------
// 
//---------Question 19

// using System;

// namespace SentenceReversal
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter a sentence: ");
//             string sentence = Console.ReadLine();

//             string reversedSentence = ReverseSentence(sentence);
//             Console.WriteLine($"Reversed Sentence: {reversedSentence}");
//         }

//         static string ReverseSentence(string sentence)
//         {
//             string[] words = sentence.Split(' ');
//             Array.Reverse(words);
//             return string.Join(" ", words);
//         }
//     }
// }

// --------------------------------------- Tutorial -----------------------------------------------

//---------Question 20

// using System;

// namespace BaseConversion
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the number: ");
//             string number = Console.ReadLine();

//             Console.WriteLine("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
//             int currentBase = int.Parse(Console.ReadLine());

//             Console.WriteLine("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
//             int desiredBase = int.Parse(Console.ReadLine());

//             int decimalValue = Convert.ToInt32(number, currentBase);
//             string result = Convert.ToString(decimalValue, desiredBase);

//             Console.WriteLine($"Converted Number: {result}");
//         }
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StringExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny." +
                "The character—also known by the code number 007 (pronounced double-O - seven)—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
            Console.WriteLine("enter y or Y to process james bond string");
            string canContinue = "y";
            do
            {
                Console.WriteLine("1. Find out count of blanck spaces in the string");
                Console.WriteLine("2. Find out count of words in the string");
                Console.WriteLine("3. Find out count of statements in the string");
                Console.WriteLine("4. No of occurences of word in a string");
                Console.WriteLine("5. Find out count of vovels (a,e,i,o,u) in the string");
                Console.WriteLine("6. Convert first character of each word in string into the uppercase");
                Console.WriteLine("7. Print all special characters from the string.");
                Console.WriteLine("Enter the Option");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("No of blanck spaces in the string are = " + str.CountIndividual(' '));
                        break;
                    case 2:
                        int words = str.CountIndividual(' ') + Convert.ToInt32("1");
                        Console.WriteLine("count of words in the string are = " + words);
                        break;
                    case 3:
                        Console.WriteLine("No of statements in the string are = " + str.CountIndividual('.'));
                        break;
                    case 4:
                        Console.WriteLine("Enter the world whose frequency has to be found:");
                        Console.WriteLine("Count of occurences of the " +
                            "entered world are = " + str.Occurences(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("Count of vowels are: ");
                        Console.WriteLine();
                        Console.WriteLine("a and A :" + str.CountIndividual('a') + str.CountIndividual('A'));
                        Console.WriteLine("e and E :" + str.CountIndividual('e') + str.CountIndividual('E'));
                        Console.WriteLine("i and I :" + str.CountIndividual('i') + str.CountIndividual('I'));
                        Console.WriteLine("o and O :" + str.CountIndividual('o') + str.CountIndividual('O'));
                        Console.WriteLine("u and U :" + str.CountIndividual('u') + str.CountIndividual('U'));
                        break;
                    case 6:
                        Console.WriteLine(str.CapitalizeFirstLetter());
                        break;
                    case 7:
                        str.SpecialChar();
                        break;
                    default:
                        break;

                }
                Console.WriteLine("Enter y or Y to continue");
                canContinue = Console.ReadLine();
                Console.Clear(); // Clearing the Screen
            } while (canContinue == "y" || canContinue == "Y");
        }
    }
}

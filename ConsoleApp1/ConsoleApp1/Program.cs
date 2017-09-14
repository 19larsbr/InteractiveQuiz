using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var WrongAnswers = 0;
            var RightAnswers = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to my quiz! Question One: The programming language C# is younger than 10 years old (answer true or false)");
                    var answer1 = Console.ReadLine();

                    if (answer1.ToLower() == "true")
                    {
                        Console.WriteLine("Sorry you got that one wrong");
                        WrongAnswers = 1;
                    }
                    else if (answer1.ToLower() == "false")
                    {
                        Console.WriteLine("Yay you got it right!");
                        RightAnswers = 1;

                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                        continue;
                    }

                    Console.WriteLine("Question 2: Would this succesfully convert a string to a double in C#: " +
                        "Convert.ToDouble(Console.ReadLine()) (enter yes or no)"
                         );
                    var answer2 = Console.ReadLine();
                    if (answer2.ToLower() == "yes")
                    {
                        Console.WriteLine("Yay you got it right!");
                        if (RightAnswers == 1)
                        {
                            RightAnswers = 2;
                        }
                        else if (RightAnswers == 0)
                        {
                            RightAnswers = 1;
                        }


                    }
                    else if (answer2.ToLower() == "no")
                    {
                        Console.WriteLine("Sorry you got it wrong");
                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                    }
                    Console.WriteLine("Question 3: A string is is a data type used in programming (yes or no) ");
                    var answer3 = Console.ReadLine();

                    if (answer3.ToLower() == "yes")
                    {
                        Console.WriteLine("Yay you got it right!");
                        if (RightAnswers == 1)
                        {
                            RightAnswers = 2;
                        }
                        else if (RightAnswers == 0)
                        {
                            RightAnswers = 1;
                        }
                        else if (RightAnswers == 2)
                        {
                            RightAnswers = 3;
                        }


                    }
                    else if (answer3.ToLower() == "no")
                    {
                        Console.WriteLine("Sorry you got it wrong");
                        if (WrongAnswers == 1)
                        {
                            WrongAnswers = 2;
                        }
                        else if (WrongAnswers == 0)
                        {
                            WrongAnswers = 1;
                        }
                        else if (WrongAnswers == 2)
                        {
                            WrongAnswers = 3;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                        continue;
                    }

                    if (RightAnswers == 2)
                    {
                        Console.WriteLine("You got 66%");
                    }
                    else if (RightAnswers == 3)
                    {
                        Console.WriteLine("Congratulations you got 100%!");
                    }
                    else if (RightAnswers == 0)
                    {
                        Console.WriteLine("Sorry you go 0%");
                    }
                    else if (RightAnswers == 1)
                    {
                        Console.WriteLine("You got 33%");
                    }
                    Console.WriteLine("Take quiz again? (enter no to exit)");
                    var FinalAnswer = Console.ReadLine();
                    if (FinalAnswer.ToLower() == "no")
                    {
                        break;
                    }
                    else if (FinalAnswer.ToLower() == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Not valid input");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not vaild input");
                    continue;
                }
            } }
        }
    } 
    
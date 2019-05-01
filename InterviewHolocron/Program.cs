using System;
using System.Reflection;

namespace InterviewHolocron
{
    class Program
    {
        static void Main(string[] args)
        {
            Holocron lightSaber = new Holocron();
            var commandList = lightSaber.ListCommands();

            Console.WriteLine("Please enter a command." + Environment.NewLine + "Available Commands are:" + lightSaber.ListCommands());

            var InputSwitch = Console.ReadLine();

            switch(InputSwitch)
            {
                case "ReverseString":
                    {
                        Console.WriteLine("Please supply a string to be reversed" + Environment.NewLine);
                        Console.WriteLine(lightSaber.ReverseString());
                        Console.ReadLine();
                        break;
                    }
                case "FizzBuzz":
                    {
                        Console.WriteLine("Please supply a number to be FizzBuzzed" + Environment.NewLine);
                        var InputStr = Console.ReadLine();
                        Console.WriteLine(lightSaber.FizzBuzz(InputStr));
                        Console.ReadLine();
                        break;
                    }
                default:
                    Console.WriteLine("Sorry, that command is not recognized. Please Try Again.");
                    break;
            }
        }

        

            



        }
    }


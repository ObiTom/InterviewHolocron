using System;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

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

            var members = lightSaber.GetType().GetMembers();
            IEnumerable<MemberInfo> method = from member in members where member.Name == InputSwitch select member;
            Console.WriteLine("Please supply a string");

            object[] inputStr = new object[1];
            inputStr[0]= Console.ReadLine();
            Console.WriteLine(lightSaber.GetType().InvokeMember(method.FirstOrDefault().Name, BindingFlags.InvokeMethod, null, lightSaber, args: inputStr));
            Console.ReadLine();

            //switch (InputSwitch)
            //{
            //    case "ReverseString":
            //        {
            //            Console.WriteLine("Please supply a string to be reversed" + Environment.NewLine);
            //            var InputStr = Console.ReadLine();
            //            Console.WriteLine(lightSaber.ReverseString(InputStr));
            //            Console.ReadLine();
            //            break;
            //        }
            //    case "FizzBuzz":
            //        {
            //            Console.WriteLine("Please supply a number to be FizzBuzzed" + Environment.NewLine);
            //            var InputStr = Console.ReadLine();
            //            Console.WriteLine(lightSaber.FizzBuzz(InputStr));
            //            Console.ReadLine();
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Sorry, that command is not recognized. Please Try Again.");
            //        break;
            //}
        }

        

            



        }
    }


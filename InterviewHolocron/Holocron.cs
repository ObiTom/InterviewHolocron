using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace InterviewHolocron
{
    public class Holocron
    {
        public string ListCommands()
        {

            var programMembers = GetType().GetMembers();
            var commands = Environment.NewLine;

            foreach (MemberInfo info in programMembers)
            {
                if (info.MemberType == MemberTypes.Method && ((System.Reflection.MethodBase)info).IsVirtual == false && 
                    (info.Name!="GetType"&&info.Name!="ListCommands"))
                    commands += info.Name + Environment.NewLine;
            }

            if (commands.Length > 0)
                return commands;
            else
                return "No accessible commands found!";


        }

        public string FizzBuzz(string InputNum)
        {
            int fbzr = 0;
            if (!Int32.TryParse(InputNum, out fbzr))
                return "I find your lack of number disturbing";
            else
                if (fbzr % 15 == 0)
                return "Fizzbuzz";
            else if (fbzr % 3 == 0)
                return "Fizz";
            else if (fbzr % 5 == 0)
                return "Buzz";
            else
                return InputNum;
                

        }

        public string ReverseString(string InputStr)
        {

            var originalString = InputStr;
            var reversedString = "";

            if (originalString.Length > 0 && !String.IsNullOrWhiteSpace(originalString))
            {
                for (int i = originalString.Length - 1; i > -1; i--)
                {
                    reversedString += originalString[i];
                }
                return reversedString;
            }
            else
                return "No string to reverse!";

        }
    }
}

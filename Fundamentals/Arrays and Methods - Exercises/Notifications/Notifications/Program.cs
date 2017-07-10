using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string SuccessOrError = Console.ReadLine();

                if (SuccessOrError == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    string success = ShowSuccess(operation, message);

                    Console.WriteLine(success);
                }

                else if (SuccessOrError == "error")
                {
                    string ErrorOperation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    string error = ShowError(ErrorOperation, code);

                    Console.WriteLine(error);
                }

            }
        }
        private static string ShowSuccess(string operation, string message)
        {
            return $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
        }
        private static string ShowError(string operation, int code)
        {
            if (code > 0)
            {

                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.";
            }
            else
            {

                return $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.";
            }
        }
    }
}

using System;

using static System.Math;
using static System.Console;

namespace CodeSamples
{
    // This class will demenostrate new features introduced in C# 6.0
    public class CSharp6
    {
        //Auto-Property enhancements
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Auto Property Initialization
        public string FirstNameInitialization { get; set; } = "Name";

        //Read Only Auto Property
        public string ReadOnlyFirstName { get; private set; }
        public string ReadOnlyLastName { get; private set; }

        //True Read-only behavior
        public string TrueReadOnlyFirstName { get; }
        public string TrueReadOnlyLastName { get; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; } = "Message";

        /// <summary>
        /// Adds the specified first.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public int Add(int first, int second)
        {
            return first + second;
        }

        /// <summary>
        /// Writes the log.
        /// </summary>
        public void WriteLog()
        {
            Console.WriteLine(Message);
        }

        /// <summary>
        /// Add extended.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public int AddEx(int first, int second) => first + second;

        /// <summary>
        /// extended function to Write the log.
        /// </summary>
        public void WriteLogEx() => Console.WriteLine($"{Message}");

        //Interpolated Strings
        public void WriteMessage() => Console.WriteLine($"Message is {Message} ");

        public void WriteMessageEx1() => Console.WriteLine($"Message is \"important\" {Message} ");
        public void WriteMessageEx2() => Console.WriteLine($"Message is {(string.IsNullOrWhiteSpace(Message) ? "empty" : "Not empty")} ");

        /// <summary>
        /// Usings the static feature.
        /// </summary>
        public void UsingStaticFeature()
        {
            var power = Pow(2, 2);
            WriteLine(power);
        }

        /// <summary>
        /// Null Conditional operator.
        /// </summary>
        public void NullConditionalOPerator()
        {
            string name = null;
            var length = name?.Length;
            Console.WriteLine(length);
        }

        private static void FirstMethod() => SecondMethod();

        private static void SecondMethod() => ThirdMethod();

        private static void ThirdMethod() => ForthMethod();

        private static void ForthMethod()
        {
            throw new ArgumentException(message: "Message", innerException: new ArgumentNullException("ArgumentNullException"));
        }

        /// <summary>
        /// Exceptions the filters.
        /// </summary>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.ArgumentNullException">ArgumentNullException</exception>
        public void ExceptionFilters()
        {
            try
            {
                FirstMethod();
            }
            catch (Exception ex) when(ex.InnerException !=null)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


    }
}

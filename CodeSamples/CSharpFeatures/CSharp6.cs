using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}

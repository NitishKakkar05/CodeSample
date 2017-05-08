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
    }
}

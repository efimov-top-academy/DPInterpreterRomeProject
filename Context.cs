using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPInterpreterRomeProject
{
    internal class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }
        public Context(string input)
        {
            Input = input;
        }
    }
}

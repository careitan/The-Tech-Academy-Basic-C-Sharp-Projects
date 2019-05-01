using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedConstructors
{
    public class Something
    {
        public string Word { get; set; }
        public int Number { get; set; }

        public Something(int Input) : this(string.Empty, Input)
        {
        }

        public Something(string Input) : this(Input, int.MinValue)
        {
        }

        public Something(string Input, int Value)
        {
            Word = Input;
            Number = Value;
        }

    }
}

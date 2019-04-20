using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    public static class LittlePigs
    {
        public static int Straw(int input)
        {
            return input / 3;
        }

        public static int Wood(int input)
        {
            return 7 * input;
        }

        public static int Brick(int input)
        {
            return input * input;
        }

    }
}

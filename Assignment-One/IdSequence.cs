using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_One
{
    public static class IdSequence
    {
        private static int current = 0;
        public static int Next
        {
            get
            {
                return ++current;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    public class WarToken
    {
        public int Value
        {
            get;
            private set;
        }

        private WarToken() {}

        public WarToken(int value)
        {
            Value = value;
        }
    }
}

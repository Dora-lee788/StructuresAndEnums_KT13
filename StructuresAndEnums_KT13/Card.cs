using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnums_KT13
{
        public struct Card
        {
            public Suit Suit;
            public Rank Rank;

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }
    
}

using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jesses_Tutor.Main
{
    public class SpecialCard : Card
    {
        public override string GetDescription()
        {
            return $"SPECIAL CARD - Value: {Value}, Suit: {Suit}";
        }
    }
}



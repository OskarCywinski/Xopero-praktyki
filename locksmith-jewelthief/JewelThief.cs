using System;
using System.Collections.Generic;
using System.Text;

namespace locksmith_jewelthief
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradnę zawartość sejfu! " + stolenJewels.Sparkle());
        }
    }
}

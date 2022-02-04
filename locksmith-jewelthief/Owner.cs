using System;
using System.Collections.Generic;
using System.Text;

namespace locksmith_jewelthief
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów! " + safeContents.Sparkle());
        }
    }
}

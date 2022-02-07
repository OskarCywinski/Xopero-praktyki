using System;
using System.Collections.Generic;
using System.Text;

namespace Pszczoły2
{
    class StingPatrol : Worker
    {

        public int AlertLevel { get; private set; }
        public int Stingerlength { get; set; }
        public bool SharpenStinger(int Length)
        {
            return true;
        }
        public bool LookForEnemies()
        {
            return true;
        }

        public void Sting(string Enemy)
        {

        }
    }
}

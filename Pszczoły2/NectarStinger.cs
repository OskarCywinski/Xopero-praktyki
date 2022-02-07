using System;
using System.Collections.Generic;
using System.Text;

namespace Pszczoły2
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger()
        {

        }
        public int AlertLevel { get; private set; }

        public int StingerLength { get; set; }

        public bool LookForEnemies()
        {
            return true;
        }
        public int SharpenStinger(int Length)
        {
            return Length;
        }
        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }




    }
}

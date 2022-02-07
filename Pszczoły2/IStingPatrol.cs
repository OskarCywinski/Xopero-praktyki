using System;
using System.Collections.Generic;
using System.Text;

namespace Pszczoły2
{
    public interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Length);
    }
}

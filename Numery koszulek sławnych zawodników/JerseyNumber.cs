using System;
using System.Collections.Generic;
using System.Text;

namespace Numery_koszulek_sławnych_zawodników
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player,int numberRetired)
        {
            Player = player;
            YearRetired = numberRetired;
        }
    }
}

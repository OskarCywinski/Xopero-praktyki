using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Słonie
{
    class Elephant
    {
       public int EarSize;
       public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uczy mają " + EarSize + " centymetrów szerokości", Name + " mówi...");
        }
    }
}

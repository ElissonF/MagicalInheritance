using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalInheritance
{
    public class ArchMage : Mage
    {
        public ArchMage(string title) : base(title)
        {
        }
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }
        public Storm CastLightningStorm()
        {
            return new Storm("lightining", true, Title);
        }
    }
}

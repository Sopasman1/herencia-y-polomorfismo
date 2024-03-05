using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Autos
    {
        public virtual string Motor()
        {
            return "V10 with 50 horsepower";
        }
    }

    public class AudiS8Mk2 : Autos
    {
        public override string Motor()
        {
            return base.Motor() + "\nAir suspension with sound suppression";
        }
    }

    public class Lamborghini : Autos
    {
        public override string Motor()
        {
            return base.Motor() + "\nThe crankshaft is offset by 18°, leaving it at 72°, to improve the firing order.";
        }
    }
}

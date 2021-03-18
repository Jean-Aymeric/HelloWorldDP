using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Decorator {
    class Smiley : Decorator {
        public Smiley(AbstractCountry country) : base(country) {
        }

        public override string getHelloMessage() {
            return base.getHelloMessage() + " :)";
        }
    }
}

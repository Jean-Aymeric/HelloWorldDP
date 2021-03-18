using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Decorator {
    public class Smiley : Decorator {
        public Smiley(ICountry country) : base(country) {
        }

        public override string getHelloMessage() {
            return base.getHelloMessage() + " :)";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Decorator {
    class BorderStar : Border {
        public BorderStar(AbstractCountry country) : base(country, '*') {
        }
    }
}

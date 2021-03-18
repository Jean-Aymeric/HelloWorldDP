using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Decorator {
    class BorderUnderscore : Border {
        public BorderUnderscore(AbstractCountry country) : base(country, '_', 80) {
        }
    }
}

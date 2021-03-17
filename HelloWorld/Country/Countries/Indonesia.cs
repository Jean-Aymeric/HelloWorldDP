using HelloWorld.Country.BehaviorGetDate;
using HelloWorld.Country.BehaviorGetHello;

namespace HelloWorld.Country.Countries {
    public class Indonesia : Country {
        public Indonesia() : base(new BehaviorGetIndonesianHello(), new BehaviorGetDateType2()) {
        }
    }
}

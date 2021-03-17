using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class Indonesia : Country {
        public Indonesia() : base(new BehaviorGetIndonesianHello(), new BehaviorGetDateType2()) {
        }
    }
}

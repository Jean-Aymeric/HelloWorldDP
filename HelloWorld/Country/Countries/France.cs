using HelloWorld.Country.BehaviorGetDate;
using HelloWorld.Country.BehaviorGetHello;

namespace HelloWorld.Country.Countries {
    public class France : Country {
        public France() : base(new BehaviorGetFrenchHello(), new BehaviorGetDateType1()) {
        }
    }
}

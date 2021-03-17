using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class France : Country {
        public France() : base(new BehaviorGetFrenchHello(), new BehaviorGetDateType1()) {
        }
    }
}

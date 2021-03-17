using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class UnitedKingdom : Country {
        public UnitedKingdom() : base(new BehaviorGeEnglishHello(), new BehaviorGetDateType1()) {
        }
    }
}

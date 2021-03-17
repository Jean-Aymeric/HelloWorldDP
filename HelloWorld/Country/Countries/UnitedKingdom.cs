using HelloWorld.Country.BehaviorGetDate;
using HelloWorld.Country.BehaviorGetHello;

namespace HelloWorld.Country.Countries {
    public class UnitedKingdom : Country {
        public UnitedKingdom() : base(new BehaviorGeEnglishHello(), new BehaviorGetDateType1()) {
        }
    }
}

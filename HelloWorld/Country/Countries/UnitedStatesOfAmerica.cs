using HelloWorld.Country.BehaviorGetDate;
using HelloWorld.Country.BehaviorGetHello;

namespace HelloWorld.Country.Countries {
    public class UnitedStatesOfAmerica : Country {
        public UnitedStatesOfAmerica() : base(new BehaviorGeEnglishHello(), new BehaviorGetDateType2()) {
        }
    }
}

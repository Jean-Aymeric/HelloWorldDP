using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class UnitedStatesOfAmerica : Country {
        public UnitedStatesOfAmerica() : base(new BehaviorGeEnglishHello(), new BehaviorGetDateType2()) {
        }
    }
}

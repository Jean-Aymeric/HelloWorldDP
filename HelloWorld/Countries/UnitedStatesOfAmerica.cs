using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class UnitedStatesOfAmerica : Country {
        public UnitedStatesOfAmerica() : base(FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English), FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type2)) {
        }
    }
}

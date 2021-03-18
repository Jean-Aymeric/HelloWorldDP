using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class UnitedKingdom : Country {
        public UnitedKingdom() : base(FactoryBehaviorGetHello.Create(BehaviorGetHelloType.English), FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type1)) {
        }
    }
}

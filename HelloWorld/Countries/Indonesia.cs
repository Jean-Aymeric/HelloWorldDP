using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class Indonesia : Country {
        public Indonesia() : base(FactoryBehaviorGetHello.Create(BehaviorGetHelloType.Indonesian), FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type2)) {
        }
    }
}

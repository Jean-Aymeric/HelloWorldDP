using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    public class France : Country {
        public France() : base(FactoryBehaviorGetHello.Create(BehaviorGetHelloType.French), FactoryBehaviorGetDate.Create(BehaviorGetDateType.Type1)) {
        }
    }
}

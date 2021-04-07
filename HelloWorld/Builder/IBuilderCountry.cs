using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    interface IBuilderCountry {
        IBehaviorGetHello buildBehaviorGetHello();
        IBehaviorGetDate buildBehaviorGetDate();
        ICountry getCountry();
    }
}

using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    public abstract class BuilderCountry : IBuilderCountry {
        public abstract IBehaviorGetDate buildBehaviorGetDate();
        public abstract IBehaviorGetHello buildBehaviorGetHello();
        public abstract ICountry getCountry();
    }
}

using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;
using HelloWorld.Countries;

namespace HelloWorld.Builder {
    public abstract class BuilderCountry : IBuilderCountry {
        public abstract IBehaviorGetDate buildBehaviorGetDate();
        public abstract IBehaviorGetHello buildBehaviorGetHello();
        public abstract ICountry getCountryExtended();

        public ICountry getCountry() {
            return new ProxyCountry(this.getCountryExtended());
        }
    }
}

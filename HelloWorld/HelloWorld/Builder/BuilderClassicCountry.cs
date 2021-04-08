using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Builder {
    abstract class BuilderClassicCountry : BuilderCountry {
        public override ICountry getCountry() {
            return (Country) new Country(this.buildBehaviorGetHello(), this.buildBehaviorGetDate());
        }
    }
}

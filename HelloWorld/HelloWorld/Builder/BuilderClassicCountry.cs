using HelloWorld.Countries;

namespace HelloWorld.Builder {
    abstract class BuilderClassicCountry : BuilderCountry {
        public override ICountry getCountry() {
            return new Country(this.buildBehaviorGetHello(), this.buildBehaviorGetDate());
        }
    }
}

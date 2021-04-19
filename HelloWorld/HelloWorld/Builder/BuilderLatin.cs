using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;
using HelloWorld.Countries;

namespace HelloWorld.Builder {
    class BuilderLatin : BuilderCountry {
        public override IBehaviorGetDate buildBehaviorGetDate() {
            return null;
        }

        public override IBehaviorGetHello buildBehaviorGetHello() {
            return null;
        }

        public override ICountry getCountryExtended() {
            return new LatinAdapted();
        }
    }
}

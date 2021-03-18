using HelloWorld.Old;

namespace HelloWorld.Countries {
    class LatinAdapted : AbstractCountry {
        private readonly Latin _latin = new Latin();
        public override string getHelloMessage() {
            return _latin.ave;
        }
    }
}

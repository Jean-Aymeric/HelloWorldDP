using HelloWorld.Old;

namespace HelloWorld.Countries {
    class LatinAdapted : BridgeCountry {
        private readonly Latin _latin = new Latin();

        public LatinAdapted() : base(null, null) { }

        public override string getHelloMessage() {
            return _latin.ave;
        }
    }
}

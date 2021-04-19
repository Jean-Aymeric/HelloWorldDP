using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;
using HelloWorld.Old;

namespace HelloWorld.Countries {
    class LatinAdapted : Bridge {
        private readonly Latin _latin = new Latin();

        public LatinAdapted() : base(null, null) { }

        public override string getHelloMessage() {
            return _latin.ave;
        }
    }
}

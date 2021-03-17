using HelloWorld.Country.BehaviorGetDate;
using HelloWorld.Country.BehaviorGetHello;

namespace HelloWorld.Country {
    public abstract class Country : ICountry {
        private readonly IBehaviorGetHello behaviorGetHello;
        private readonly IBehaviorGetDate behaviorGetDate;

        public Country(IBehaviorGetHello behaviorGetHello, IBehaviorGetDate behaviorGetDate) {
            this.behaviorGetHello = behaviorGetHello;
            this.behaviorGetDate = behaviorGetDate;
        }

        public string getHello() {
            return behaviorGetHello.getHello();
        }

        public string getDate() {
            return behaviorGetDate.getDate();
        }

        public string getHelloMessage() {
            return getDate() + " : " + getHello();
        }
    }
}


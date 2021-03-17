using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld {
    public abstract class Country : ICountry {
        public IBehaviorGetHello BehaviorGetHello { get; }
        public IBehaviorGetDate BehaviorGetDate { get; }

        public Country(IBehaviorGetHello behaviorGetHello, IBehaviorGetDate behaviorGetDate) {
            this.BehaviorGetHello = behaviorGetHello;
            this.BehaviorGetDate = behaviorGetDate;
        }

        public string getHello() {
            return BehaviorGetHello.getHello();
        }

        public string getDate() {
            return BehaviorGetDate.getDate();
        }

        public string getHelloMessage() {
            return getDate() + " : " + getHello();
        }
    }
}


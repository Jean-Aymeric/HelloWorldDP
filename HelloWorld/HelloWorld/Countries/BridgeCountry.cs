﻿using HelloWorld.BehaviorGetDate;
using HelloWorld.BehaviorGetHello;

namespace HelloWorld.Countries {
    abstract class BridgeCountry : AbstractCountry, IGetDate, IGetHello {
        public IBehaviorGetHello BehaviorGetHello { get; }
        public IBehaviorGetDate BehaviorGetDate { get; }

        public BridgeCountry(IBehaviorGetHello behaviorGetHello, IBehaviorGetDate behaviorGetDate) {
            this.BehaviorGetHello = behaviorGetHello;
            this.BehaviorGetDate = behaviorGetDate;
        }

        public string getHello() {
            return BehaviorGetHello.getHello();
        }

        public string getDate() {
            return BehaviorGetDate.getDate();
        }
    }
}
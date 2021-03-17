using System;

namespace HelloWorld.Country.BehaviorGetDate {
    class BehaviorGetDateType1 : IBehaviorGetDate {
        public string getDate() {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
    }
}

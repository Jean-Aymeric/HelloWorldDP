using System;

namespace HelloWorld.Country.BehaviorGetDate {
    class BehaviorGetDateType2 : IBehaviorGetDate {
        public string getDate() {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}

using System;

namespace HelloWorld.BehaviorGetDate {
    class BehaviorGetDateType1 : IBehaviorGetDate {
        public string getDate() {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

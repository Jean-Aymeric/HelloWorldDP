using System.Collections.Generic;

namespace HelloWorld.BehaviorGetDate {
    public class FactoryBehaviorGetDate {
        private static Dictionary<BehaviorGetDateType, IBehaviorGetDate> Flyweight { get; } = new Dictionary<BehaviorGetDateType, IBehaviorGetDate>();
        
        public static IBehaviorGetDate Create(BehaviorGetDateType type) {
            if (! Flyweight.ContainsKey(type)) {
                switch (type) {
                    case BehaviorGetDateType.Type1:
                        Flyweight[type] = new BehaviorGetDateType1();
                        break;
                    case BehaviorGetDateType.Type2:
                        Flyweight[type] = new BehaviorGetDateType2();
                        break;
                    default:
                        Flyweight[type] = new BehaviorGetDateType1();
                        break;
                }
            }
            return Flyweight[type];
        }
    }
}

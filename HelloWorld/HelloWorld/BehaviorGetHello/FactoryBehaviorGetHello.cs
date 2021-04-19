using System.Collections.Generic;

namespace HelloWorld.BehaviorGetHello {
    public class FactoryBehaviorGetHello {
        private static Dictionary<BehaviorGetHelloType, IBehaviorGetHello> Flyweight { get; } = new Dictionary<BehaviorGetHelloType, IBehaviorGetHello>();

        public static IBehaviorGetHello Create(BehaviorGetHelloType type) {
            if (!Flyweight.ContainsKey(type)) {
                switch (type) {
                    case BehaviorGetHelloType.English:
                        Flyweight[type] = new BehaviorGeEnglishHello();
                        break;
                    case BehaviorGetHelloType.French:
                        Flyweight[type] = new BehaviorGetFrenchHello();
                        break;
                    case BehaviorGetHelloType.Indonesian:
                        Flyweight[type] = new BehaviorGetIndonesianHello();
                        break;
                    default:
                        Flyweight[type] = new BehaviorGeEnglishHello();
                        break;
                }
            }
            return Flyweight[type];
        }
    }
}

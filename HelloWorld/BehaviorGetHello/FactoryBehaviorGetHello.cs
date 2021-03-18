namespace HelloWorld.BehaviorGetHello {
    public class FactoryBehaviorGetHello {
        public static IBehaviorGetHello Create(BehaviorGetHelloType type) {
            switch (type) {
                case BehaviorGetHelloType.English:
                    return new BehaviorGeEnglishHello();
                case BehaviorGetHelloType.French:
                    return new BehaviorGetFrenchHello();
                case BehaviorGetHelloType.Indonesian:
                    return new BehaviorGetIndonesianHello();
                default:
                    return new BehaviorGeEnglishHello();
            }
        }
    }
}

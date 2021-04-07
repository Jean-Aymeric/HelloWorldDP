namespace HelloWorld.BehaviorGetDate {
    public class FactoryBehaviorGetDate {
        public static IBehaviorGetDate Create(BehaviorGetDateType type) {
            switch (type) {
                case BehaviorGetDateType.Type1:
                    return new BehaviorGetDateType1();
                case BehaviorGetDateType.Type2:
                    return new BehaviorGetDateType2();
                default:
                    return new BehaviorGetDateType1();
            }
        }
    }
}

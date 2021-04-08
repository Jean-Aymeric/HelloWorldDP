namespace HelloWorld {
    public abstract class AbstractCountry : ICountry {
        public object Clone() {
            return (ICountry) this.MemberwiseClone();
        }

        public abstract string getHelloMessage();
    }
}

namespace HelloWorld.Countries {
    public abstract class AbstractCountry : ICountry {
        public abstract string getHelloMessage();

        public object Clone() {
            return (ICountry)this.MemberwiseClone();
        }
    }
}

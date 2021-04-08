namespace HelloWorld.AbstractFactory {
    abstract class FactoryMake {
        public string Name { get; set; }

        public abstract ICountry make(string Name);

        public FactoryMake(string name) {
            Name = name;
        }

        public bool isName(string name) {
            return name == Name;
        }
    }
}

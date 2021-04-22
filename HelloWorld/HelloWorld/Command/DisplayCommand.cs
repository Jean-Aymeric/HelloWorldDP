namespace HelloWorld.Command {
    abstract class DisplayCommand {
        protected ICountry Country {get; set;}

        public DisplayCommand(ICountry country) {
            Country = country;
        }
        public abstract void execute();
    }
}

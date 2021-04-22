using System;

namespace HelloWorld.Command {
    class ConsoleCommand : DisplayCommand {
        public ConsoleCommand(ICountry country) : base(country) { }

        public override void execute() {
            Console.WriteLine(Country.getHelloMessage());
        }
    }
}

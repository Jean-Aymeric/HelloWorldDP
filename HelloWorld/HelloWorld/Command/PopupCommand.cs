using System.Windows.Forms;

namespace HelloWorld.Command {
    class PopupCommand : DisplayCommand {
        public PopupCommand(ICountry country) : base(country) { }

        public override void execute() {
            MessageBox.Show(Country.getHelloMessage(), "HelloWorld");
        }
    }
}

namespace HelloWorld.Command {
    class Displayer {
        private DisplayCommand Command { get; set; }

        public Displayer(DisplayCommand command) {
            Command = command;
        }
        public void display() {
            Command.execute();
        }
    }
}

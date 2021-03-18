namespace HelloWorld.Decorator {
    class Border : Decorator {
        private string BorderString { get; set; }
        public int CharacterNumber { get; }
        public char BorderCharacter { get; }

        public Border(AbstractCountry country, char borderCharacter = '-', int characterNumber = 50) : base(country) {
            this.CharacterNumber = characterNumber;
            this.BorderCharacter = borderCharacter;
            BorderString = "";
            for (int i = 0; i < CharacterNumber; i++) {
                BorderString += BorderCharacter;
            }
        }

        public override string getHelloMessage() {
            return BorderString + "\n" + base.getHelloMessage() + "\n" + BorderString;
        }
    }
}

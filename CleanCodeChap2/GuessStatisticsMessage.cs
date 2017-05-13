namespace CleanCodeChap2
{
    internal sealed class GuessStatisticsMessage
    {
        string _number;
        string _verb;
        string _pluralModifier;


        public string Make(string candidate, int count)
        {
            CreatePluralDependentMessageParts(count);
            return $"There {_verb} {_number} {candidate}{_pluralModifier}";
        }

        public void CreatePluralDependentMessageParts(int count)
        {
            switch (count)
            {
                case 0:
                    ThereAreNoLetters();
                    break;
                case 1:
                    ThereIsOneLetter();
                    break;
                default:
                    ThereAreMannyLetters(count);
                    break;
            }
        }

        private void ThereAreMannyLetters(int count)
        {
            _number = count.ToString();
            _verb = "are";
            _pluralModifier = "s";
        }

        private void ThereIsOneLetter()
        {
            _number = "1";
            _verb = "is";
            _pluralModifier = "";
        }

        private void ThereAreNoLetters()
        {
            _number = "no";
            _verb = "are";
            _pluralModifier = "s";
        }
    }
}

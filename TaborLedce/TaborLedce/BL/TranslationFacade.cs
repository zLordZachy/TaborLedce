namespace TaborLedce.BL
{
    public class TranslationFacade : ITranslationFacade
    {
        public string TranslateFromMorseCodeToClassic(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
                return string.Empty;

            string[] splitedText = inputText.Split('|');

            foreach (string morseCodeLettr in splitedText)
            {
                string textLettr = TranslateMorsecodeLetter(morseCodeLettr);
            }

            return "";
        }

        private string TranslateMorsecodeLetter(string morseCodeLettr)
        {
            return "";
        }
    }
}

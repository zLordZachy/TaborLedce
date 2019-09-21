using System.Collections.Generic;
using System.Linq;
using TaborLedce.Models;

namespace TaborLedce.BL
{
    public class TranslationFacade : ITranslationFacade
    {
        public string TranslateFromMorseCodeToClassic(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
                return string.Empty;

            List<MorseCodeItem> morseCodeItems = MorseCodeItems.GetAll();

            string[] splitedText = inputText.Split('|');
            string outputText = string.Empty;

            foreach (string morseCodeLettr in splitedText)
            {
                if (string.IsNullOrEmpty(morseCodeLettr)|| string.IsNullOrWhiteSpace(morseCodeLettr))
                {
                    outputText += " ";
                    continue;
                }


                MorseCodeItem code = TranslateMorsecodeLetter(morseCodeLettr, morseCodeItems);
                if (code != null)
                {
                    outputText += code.Lettr;
                }
            }

            return outputText;
        }

        private MorseCodeItem TranslateMorsecodeLetter(string morseCodeLettr, List<MorseCodeItem> morseCodeItems)
        {

            return morseCodeItems.FirstOrDefault(x => x.Code.Equals(morseCodeLettr));
        }
    }
}

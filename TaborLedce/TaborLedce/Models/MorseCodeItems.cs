using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaborLedce.Models
{
    public static class MorseCodeItems
    {
        public static MorseCodeItem GetMorsecodeA() => new MorseCodeItem {Lettr = "A", Helpr = "akát", Image = "codeA.png", Code = ".―" };
        public static MorseCodeItem GetMorsecodeB() => new MorseCodeItem{Lettr = "B",Helpr = "blýskavice", Image = "codeB.png", Code = "―..." };
        public static MorseCodeItem GetMorsecodeC() => new MorseCodeItem{Lettr = "C",Helpr = "cílovníci", Image = "codeC.png", Code = "―.―." };
        public static MorseCodeItem GetMorsecodeD() => new MorseCodeItem{Lettr = "D",Helpr = "dálava, dálnice", Image = "codeD.png", Code = "―.." };
        public static MorseCodeItem GetMorsecodeE() => new MorseCodeItem{Lettr = "E",Helpr = "erb", Image = "codeE.png", Code = "." };
        public static MorseCodeItem GetMorsecodeF() => new MorseCodeItem{Lettr = "F",Helpr = "Filipíny, filiálka", Image = "codeF.png", Code = "..―" };
        public static MorseCodeItem GetMorsecodeG() => new MorseCodeItem{Lettr = "G",Helpr = "Grónská zem, gnómóny", Image = "codeG.png", Code = "――." };
        //Nepracujese
        public static MorseCodeItem GetMorsecodeCH() => new MorseCodeItem{Lettr = "CH",Helpr = "chléb nám dává, chvátá k nám sám,", Image = "codeCH.png", Code = "――――" };
        public static MorseCodeItem GetMorsecodeH() => new MorseCodeItem{Lettr = "H",Helpr = "hrachovina, holubice", Image = "codeH.png", Code = "...."};
        public static MorseCodeItem GetMorsecodeI() => new MorseCodeItem{Lettr = "I",Helpr = "ibis, Ivan", Image = "codeI.png",Code=".." };
        public static MorseCodeItem GetMorsecodeJ() => new MorseCodeItem{Lettr = "J",Helpr = "jasmín bílý, junácká hůl", Image = "codeJ.png", Code = ".―――" };
        public static MorseCodeItem GetMorsecodeK() => new MorseCodeItem{Lettr = "K",Helpr = "krákorá, království", Image = "codeK.png", Code = "―.―" };
        public static MorseCodeItem GetMorsecodeL() => new MorseCodeItem{Lettr = "L",Helpr = "lupíneček", Image = "codeL.png", Code = ".―.." };
        public static MorseCodeItem GetMorsecodeM() => new MorseCodeItem{Lettr = "M",Helpr = "hrachovina", Image = "codeM.png" , Code = "――" };
        public static MorseCodeItem GetMorsecodeN() => new MorseCodeItem{Lettr = "N",Helpr = "národ, nástup", Image = "codeN.png", Code = "―." };
        public static MorseCodeItem GetMorsecodeO() => new MorseCodeItem{Lettr = "O",Helpr = "ó náš pán, ó náš háj", Image = "codeO.png", Code = "―――" };
        public static MorseCodeItem GetMorsecodeP() => new MorseCodeItem{Lettr = "P",Helpr = "papírníci", Image = "codeP.png", Code = ".――." };
        public static MorseCodeItem GetMorsecodeQ() => new MorseCodeItem{Lettr = "Q",Helpr = "kvílí orkán", Image = "codeQ.png", Code = "――.―" };
        public static MorseCodeItem GetMorsecodeR() => new MorseCodeItem{Lettr = "R",Helpr = "rarášek", Image = "codeR.png", Code = ".―." };
        public static MorseCodeItem GetMorsecodeS() => new MorseCodeItem{Lettr = "S",Helpr = "sekera", Image = "codeS.png", Code = "..." };
        public static MorseCodeItem GetMorsecodeT() => new MorseCodeItem{Lettr = "T",Helpr = "tón", Image = "codeT.png",Code = "―" };
        public static MorseCodeItem GetMorsecodeU() => new MorseCodeItem{Lettr = "U",Helpr = "uličník", Image = "codeU.png", Code = "..―" };
        public static MorseCodeItem GetMorsecodeV() => new MorseCodeItem{Lettr = "V",Helpr = "vyvolený", Image = "codeV.png", Code = "...―" };
        public static MorseCodeItem GetMorsecodeW() => new MorseCodeItem{Lettr = "W",Helpr = "wagón klád", Image = "codeW.png", Code = ".――" };
        public static MorseCodeItem GetMorsecodeX() => new MorseCodeItem{Lettr = "X",Helpr = "Xénokratés", Image = "codeX.png", Code = "―..―" };
        public static MorseCodeItem GetMorsecodeY() => new MorseCodeItem{Lettr = "Y",Helpr = "ý se ztrácí", Image = "codeY.png", Code = "―.――" };
        public static MorseCodeItem GetMorsecodeZ() => new MorseCodeItem{Lettr = "Z",Helpr = "zrádná žena", Image = "codeZ.png", Code = "――.." };

        public static MorseCodeItem GetMorsecode0() => new MorseCodeItem{Lettr = "0",Helpr = "", Image = "code0.png", Code = "―――――" };
        public static MorseCodeItem GetMorsecode1() => new MorseCodeItem{Lettr = "1",Helpr = "", Image = "code1.png", Code = ".――――" };
        public static MorseCodeItem GetMorsecode2() => new MorseCodeItem{Lettr = "2",Helpr = "", Image = "code2.png", Code = "..―――" };
        public static MorseCodeItem GetMorsecode3() => new MorseCodeItem{Lettr = "3",Helpr = "", Image = "code3.png", Code = "...――" };
        public static MorseCodeItem GetMorsecode4() => new MorseCodeItem{Lettr = "4",Helpr = "", Image = "code4.png", Code = "....―" };
        public static MorseCodeItem GetMorsecode5() => new MorseCodeItem{Lettr = "5",Helpr = "", Image = "code5.png", Code = "....." };
        public static MorseCodeItem GetMorsecode6() => new MorseCodeItem{Lettr = "6",Helpr = "", Image = "code6.png", Code = "―...." };
        public static MorseCodeItem GetMorsecode7() => new MorseCodeItem{Lettr = "7",Helpr = "", Image = "code7.png", Code = "――..." };
        public static MorseCodeItem GetMorsecode8() => new MorseCodeItem{Lettr = "8",Helpr = "", Image = "code8.png", Code = "―――.." };
        public static MorseCodeItem GetMorsecode9() => new MorseCodeItem{Lettr = "9",Helpr = "", Image = "code9.png", Code = "――――." };

        public static List<MorseCodeItem> GetAllAlphabet()
        {
            return new List<MorseCodeItem>
            {
                GetMorsecodeA(), GetMorsecodeB(), GetMorsecodeC(), GetMorsecodeD(), GetMorsecodeE(), GetMorsecodeF(), GetMorsecodeG(),GetMorsecodeH(),
                GetMorsecodeI(), GetMorsecodeJ(),GetMorsecodeK(), GetMorsecodeL(),GetMorsecodeM(), GetMorsecodeN(), GetMorsecodeO(),GetMorsecodeP(),
                GetMorsecodeQ(), GetMorsecodeR(), GetMorsecodeS(),GetMorsecodeT(), GetMorsecodeU(),GetMorsecodeV(),GetMorsecodeW(),GetMorsecodeX(),GetMorsecodeY(),GetMorsecodeZ()
            };
        }

        public static List<MorseCodeItem> GetAllNumbers()
        {
            return new List<MorseCodeItem>
            {
                GetMorsecode0(),GetMorsecode1(), GetMorsecode2(), GetMorsecode3(), GetMorsecode4(), GetMorsecode5(), GetMorsecode6(), GetMorsecode7(),GetMorsecode8(),
                GetMorsecode9()
            };
        }

        public static List<MorseCodeItem> GetAll()
        {
            return GetAllAlphabet().Concat(GetAllNumbers()).ToList();
        }


    }
}

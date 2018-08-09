using System;
using System.Collections.Generic;
using System.Linq;
namespace HexagonalStructure
{
    public class HardCodedAdapter : IAdapter
    {
        private List<string> verses;
        public HardCodedAdapter()
        {
            verses = new List<string>();
            verses.Add("Dans le faubourg qui monte au cimetière,");
            verses.Add("Passant rêveur, j'ai souvent observé");
            verses.Add("Les croix de bois et les tombeaux de pierre");
            verses.Add("Attendant là qu'un nom y fût gravé.");
        }

        public List<string> GetLines(int number)
        {
            return verses.GetRange(0,number);
        }
    }
}

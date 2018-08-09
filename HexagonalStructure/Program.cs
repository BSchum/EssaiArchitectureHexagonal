using System;
using System.Collections.Generic;
namespace HexagonalStructure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IAdapter adapter = new HardCodedAdapter();

            IRequestVerses poetryReader = new PoetryReader(adapter);

            List<string> verses = poetryReader.GetLines(3);

            foreach(string verse in verses){
                Console.WriteLine(verse);
            }

        }
    }
}

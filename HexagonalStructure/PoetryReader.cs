using System;
using System.Collections.Generic;

namespace HexagonalStructure
{
    /* Hexagone : PoetryReader
       Port d'entré : IRequestVerses
       Port de sortie : IAdapter */
    public class PoetryReader : IRequestVerses
    {
        private IAdapter adapter;
        public PoetryReader(IAdapter adapter)
        {
            this.adapter = adapter;
        }

        public List<String> GetLines(int number){
            return adapter.GetLines(number);
        }
    }
}

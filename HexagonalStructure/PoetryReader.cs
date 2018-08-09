using System;
using System.Collections.Generic;

namespace HexagonalStructure
{
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

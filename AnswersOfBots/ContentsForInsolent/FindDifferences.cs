using AnswersOfBots.Interfaces;
using System;

namespace AnswersOfBots.ContentsForInsolent
{
    public class FindDifferences : IContentAnswer<string>
    {
        private readonly string message;
        private readonly char[] symbols = new char[33];

        public FindDifferences(string message)
        {
            this.message = message;

            CreateArraySymbols();
        }             

        public string Content()
        {
            var (FirstSymbol, SecondSymbol) = GetTwoSymbols();
            return new string(FirstSymbol + message + SecondSymbol + ".\nНайди разницу.");
        }

        private char[] CreateArraySymbols()
        {
            int counter = 0;
            for (char start = 'а'; start < 'я'; ++start)
            {
                symbols[counter] = start;
                ++counter;
            }
            symbols[32] = 'ё';

            return symbols;
        }

        private (char FirstSymbol, char SecondSymbol) GetTwoSymbols()
        {
            Random val1 = new Random(1);
            Random val2 = new Random();

            int fisrsPart = val1.Next(6, 20);
            int secondPart = val2.Next(1, 5);

            return (symbols[fisrsPart - secondPart], symbols[fisrsPart + secondPart]);
        }
    }
}

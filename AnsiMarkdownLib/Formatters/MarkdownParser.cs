using System;
using System.Collections.Generic;

namespace AnsiMarkdownLib.Formatters
{
    public class MarkdownParser
    {
        public static List<(int Open, int Close)> FindMarkdownTags(string text, string markdownSymbol)
        {
            List<(int, int)> result = new List<(int, int)>();
            int index = 0;
            int symbolLength = markdownSymbol.Length;

            while (index < text.Length)
            {
                int openIndex = text.IndexOf(markdownSymbol, index);
                if (openIndex == -1) break;

                int closeIndex = text.IndexOf(markdownSymbol, openIndex + symbolLength);
                if (closeIndex == -1) break;

                result.Add((openIndex, closeIndex));
                index = closeIndex + symbolLength;
            }
            return result;
        }
    }
}

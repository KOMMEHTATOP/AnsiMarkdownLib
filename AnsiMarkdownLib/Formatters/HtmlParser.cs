using System;
using System.Collections.Generic;

namespace AnsiMarkdownLib.Formatters
{
    public class HtmlParser
    {
        public static List<(int Open, int Close)> FindBoldTags(string text)
        {
            Stack<int> openTags = new Stack<int>();
            List<(int Open, int Close)> result = new List<(int, int)>();
            int index = 0;

            while (index < text.Length)
            {
                int openIndex = text.IndexOf("<b>", index);
                int closeIndex = text.IndexOf("</b>", index);

                if (openIndex != -1 && (openIndex < closeIndex || closeIndex == -1))
                {
                    openTags.Push(openIndex);
                    index = openIndex + 3;
                }
                else if (closeIndex != -1)
                {
                    if (openTags.Count > 0)
                    {
                        int openPos = openTags.Pop();
                        result.Add((openPos, closeIndex));
                    }
                    index = closeIndex + 4;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}

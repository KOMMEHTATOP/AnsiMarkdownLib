using AnsiMarkdownLib.Colors;
using System;
namespace AnsiMarkdownLib.Formatters
{
    public class TextFormatter
    {
        public static string ApplyAnsiColor(string text, AvailableColors color)
        {
            int colorCode = BaseAnsiColors.GetAnsiCode(color);
            return $"\u001b[{colorCode}m{text}\u001b[0m";
        }

        public static string ApplyAnsiBold(string text) => $"\x1b[1m{text}\x1b[0m";
        public static string ApplyAnsiUnderline(string text) => $"\x1b[4m{text}\x1b[0m";

        public static string ApplyMultipleAnsi(string text, AvailableColors? color = null, bool isBold = false, bool isUnderline = false)
        {
            string boldCode = isBold ? "1;" : "";
            string underlineCode = isUnderline ? "4;" : "";
            string colorCode = color.HasValue ? BaseAnsiColors.GetAnsiCode(color.Value).ToString() : "";
            return $"\x1b[{boldCode}{underlineCode}{colorCode}m{text}\x1b[0m";
        }

        public static string ApplyMarkDownBold(string text) => $"**{text}**";
        public static string ApplyMarkDownItalics(string text) => $"_{text}_";
        public static string ApplyMarkDownStrike(string text) => $"~~{text}~~";
        public static string ApplyMarkDownHidden(string text) => $"||{text}||";

        public static string ApplyMultipleMarkDown(string text, bool isBold = false, bool isItalic = false, bool isStrike = false, bool isHidden = false)
        {
            if (isBold) text = $"**{text}**";
            if (isItalic) text = $"_{text}_";
            if (isStrike) text = $"~~{text}~~";
            if (isHidden) text = $"||{text}||";
            return text;
        }
    }
}

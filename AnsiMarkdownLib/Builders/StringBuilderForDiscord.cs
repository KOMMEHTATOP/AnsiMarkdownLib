using AnsiMarkdownLib.Colors;
using AnsiMarkdownLib.Formatters;
using AnsiMarkdownLib.Helpers;

namespace AnsiMarkdownLib.Builders
{
    public class StringBuilderForDiscord
    {
        public static string ApplyAnsiColor(string text, AvailableColors color)
        {
            string formattedText = TextFormatter.ApplyAnsiColor(text, color);
            return AnsiBufferForDiscord(formattedText);
        }
        public static string ApplyAnsiBold(string text)
        {
            string formattedText = TextFormatter.ApplyAnsiBold(text);
            return AnsiBufferForDiscord(formattedText);
        }

        public static string ApplyAnsiUnderline(string text)
        {
            string formattedText = TextFormatter.ApplyAnsiUnderline(text);
            return AnsiBufferForDiscord(formattedText);
        }

        public static string ApplyMultipleAnsi(string text, AvailableColors? color = null, bool isBold = false, bool isUnderlined = false)
        {
            string formattedText = TextFormatter.ApplyMultipleAnsi(text, color, isBold, isUnderlined);
            return AnsiBufferForDiscord(formattedText);
        }

        public static string ApplyMarkDownBold(string text)
        {
            string formattedText = TextFormatter.ApplyMarkDownBold(text);
            return MarkDownBufferForDiscord(formattedText);
        }

        public static string ApplyMarkDownItalics(string text)
        {
            string formattedText = TextFormatter.ApplyMarkDownItalics(text);
            return MarkDownBufferForDiscord(formattedText);
        }

        public static string ApplyMarkDownStrike(string text)
        {
            string formattedText = TextFormatter.ApplyMarkDownStrike(text);
            return MarkDownBufferForDiscord(formattedText);
        }

        public static string ApplyMarkDownHidden(string text)
        {
            string formattedText = TextFormatter.ApplyMarkDownHidden(text);
            return MarkDownBufferForDiscord(formattedText);
        }

        public static string ApplyMultipleMarkDown(string text, bool isBold, bool isItalic, bool isStrike, bool isHidden)
        {
            string formattedText = TextFormatter.ApplyMultipleMarkDown(text, isBold, isItalic, isStrike, isHidden);
            return MarkDownBufferForDiscord(formattedText);
        }


        private static string AnsiBufferForDiscord(string formattedText) => ClipboardHelper.CopyToClipboard(formattedText, true);

        private static string MarkDownBufferForDiscord(string formattedText) => ClipboardHelper.CopyToClipboard(formattedText, false);

    }
}

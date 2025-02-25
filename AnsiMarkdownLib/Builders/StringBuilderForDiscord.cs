using AnsiMarkdownLib.Colors;
using AnsiMarkdownLib.Helpers;
using System.Text.RegularExpressions;

public class StringBuilderForDiscord
{
    public static string ApplyAnsiColor(string text, AvailableColors color) => AnsiBufferForDiscord(TextFormatter.ApplyAnsiColor(text, color));
    public static string ApplyAnsiBold(string text) => AnsiBufferForDiscord(TextFormatter.ApplyAnsiBold(text));
    public static string ApplyAnsiUnderline(string text) => AnsiBufferForDiscord(TextFormatter.ApplyAnsiUnderline(text));

    public static string ApplyMultipleAnsi(string text, AvailableColors? color = null, bool isBold = false, bool isUnderlined = false)
    {
        return AnsiBufferForDiscord(TextFormatter.ApplyMultipleAnsi(text, color, isBold, isUnderlined));
    }

    public static string ApplyMarkDownBold(string text) => MarkDownBufferForDiscord(TextFormatter.ApplyMarkDownBold(text));
    public static string ApplyMarkDownItalics(string text) => MarkDownBufferForDiscord(TextFormatter.ApplyMarkDownItalics(text));
    public static string ApplyMarkDownStrike(string text) => MarkDownBufferForDiscord(TextFormatter.ApplyMarkDownStrike(text));
    public static string ApplyMarkDownHidden(string text) => MarkDownBufferForDiscord(TextFormatter.ApplyMarkDownHidden(text));

    private static string AnsiBufferForDiscord(string formattedText) => ClipboardHelper.CopyToClipboard(formattedText, true);
    private static string MarkDownBufferForDiscord(string formattedText) => ClipboardHelper.CopyToClipboard(formattedText, false);

    public static string ConvertToHtml(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }

        text = Regex.Replace(text, @"\*\*(.*?)\*\*", "<b>$1</b>");
        text = Regex.Replace(text, @"_(.*?)_", "<i>$1</i>");
        text = Regex.Replace(text, @"~~(.*?)~~", "<s>$1</s>");
        text = Regex.Replace(text, @"\|\|(.*?)\|\|", "<span class='spoiler'>$1</span>");

        return text;
    }
}

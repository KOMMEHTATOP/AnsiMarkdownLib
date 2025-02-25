using AnsiMarkdownLib.Colors;
using AnsiMarkdownLib.Formatters;
using System.Text.RegularExpressions;

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
        List<string> codes = new List<string>();
        if (isBold) codes.Add("1");
        if (isUnderline) codes.Add("4");
        if (color.HasValue) codes.Add(BaseAnsiColors.GetAnsiCode(color.Value).ToString());

        return $"\x1b[{string.Join(";", codes)}m{text}\x1b[0m";
    }

    public static string ToggleMarkdownStyle(string text, string markdownSymbol)
    {
        var positions = MarkdownParser.FindMarkdownTags(text, markdownSymbol);

        if (positions.Count > 0)
        {
            // Убираем стили (удаляем все найденные пары маркдауна)
            foreach (var (open, close) in positions.OrderByDescending(p => p.Open))
            {
                text = text.Remove(close, markdownSymbol.Length)
                           .Remove(open, markdownSymbol.Length);
            }
        }
        else
        {
            // Добавляем стиль вокруг всего текста
            text = $"{markdownSymbol}{text}{markdownSymbol}";
        }

        return text;
    }


    public static string ApplyMarkDownBold(string text) => ToggleMarkdownStyle(text, "**");
    public static string ApplyMarkDownItalics(string text) => ToggleMarkdownStyle(text, "_");
    public static string ApplyMarkDownStrike(string text) => ToggleMarkdownStyle(text, "~~");
    public static string ApplyMarkDownHidden(string text) => ToggleMarkdownStyle(text, "||");
}

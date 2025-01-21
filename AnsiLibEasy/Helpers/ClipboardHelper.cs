namespace AnsiMarkdownLib.Helpers
{
    internal class ClipboardHelper
    {
        public static string CopyToClipboard(string formattedText, bool isAnsi)
        {
            if (isAnsi)
            {
                string result = $"```ansi\n{formattedText}\n```";
                try
                {
                    TextCopy.ClipboardService.SetText(result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Ошибка копирования в буфер: {ex.Message}");
                }
                return result;
            }
            else
            {
                string result = $"{formattedText}";
                try
                {
                    TextCopy.ClipboardService.SetText(result);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Ошибка копирования в буфер: {ex.Message}");
                }
                return result;
            }
        }
    }
}

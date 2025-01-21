namespace AnsiMarkdownLib.Colors
{
    public enum AvailableColors
    {
        Black,
        Red,
        Green,
        Yellow,
        Blue,
        Magenta,
        Cyan,
        White,
        BlackBG,
        RedBG,
        GreenBG,
        YellowBG,
        BlueBG,
        PurpleBG,
        LightBlueBG,
        WhiteBG
    }

    public static class BaseAnsiColors
    {
        private static readonly Dictionary<AvailableColors, int> ColorCodes = new()
        {
            { AvailableColors.Black, 30 },
            { AvailableColors.Red, 31 },
            { AvailableColors.Green, 32 },
            { AvailableColors.Yellow, 33 },
            { AvailableColors.Blue, 34 },
            { AvailableColors.Magenta, 35 },
            { AvailableColors.Cyan, 36 },
            { AvailableColors.White, 37 },

            { AvailableColors.BlackBG, 40 },
            { AvailableColors.RedBG, 41 },
            { AvailableColors.GreenBG, 42 },
            { AvailableColors.YellowBG, 43 },
            { AvailableColors.BlueBG, 44 },
            { AvailableColors.PurpleBG, 45 },
            { AvailableColors.LightBlueBG, 46 },
            { AvailableColors.WhiteBG, 47 }
        };

        public static int GetAnsiCode(AvailableColors color) => ColorCodes[color];
    }
}

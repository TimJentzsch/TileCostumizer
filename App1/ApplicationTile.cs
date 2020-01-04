using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace App1
{
    public class ApplicationTile
    {
        public static readonly TextColor DEFAULT_TEXTCOLOR = TextColor.LIGHT;
        public static readonly Color DEFAULT_BACKGROUND_COLOR = Color.FromArgb(255, 0, 0, 0);
        public static readonly bool DEFAULT_TEXT_ON_SMALL = false;
        public static readonly bool DEFAULT_TEXT_ON_MEDIUM = true;
        public static readonly bool DEFAULT_TEXT_ON_LARGE = true;

        public string Path { get; set; }
        public TextColor TextColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool TextOnSmall { get; set; }
        public bool TextOnMedium { get; set; }
        public bool TextOnLarge { get; set; }

        public ApplicationTile(string path)
        {
            Path = path;
            // Set the fields to their default value
            TextColor = DEFAULT_TEXTCOLOR;
            BackgroundColor = DEFAULT_BACKGROUND_COLOR;

            TextOnSmall = DEFAULT_TEXT_ON_SMALL;
            TextOnMedium = DEFAULT_TEXT_ON_MEDIUM;
            TextOnLarge = DEFAULT_TEXT_ON_LARGE;
        }
    }

    public enum TextColor
    {
        LIGHT, DARK
    }
}

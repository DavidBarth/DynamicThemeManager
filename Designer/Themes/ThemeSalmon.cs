using System.Drawing;

namespace Designer
{
    /// <summary>
    /// Client specified theme
    /// </summary>
    public class ThemeSalmon : Theme
    {
        private Color salmonColor = Color.Salmon;

        public ThemeSalmon()
        {

        }

        public override Color GetThemeColor()
        {
            return salmonColor;
        }

       
    }
}

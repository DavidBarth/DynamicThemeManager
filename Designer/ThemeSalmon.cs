using System;
using System.Drawing;

namespace Designer
{
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

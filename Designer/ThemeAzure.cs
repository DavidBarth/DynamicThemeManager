using System.Drawing;

namespace Designer
{
    public class ThemeAzure : Theme
    {
        private Color azureColor = Color.Azure; 
        

        public ThemeAzure()
        {

        }

        public override Color GetThemeColor()
        {
            return azureColor;
        }

     }
}

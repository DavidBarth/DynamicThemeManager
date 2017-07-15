using System.Drawing;

namespace Designer
{
    /// <summary>
    /// Client specifed theme
    /// </summary>
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

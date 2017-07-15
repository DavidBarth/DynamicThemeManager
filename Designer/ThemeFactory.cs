namespace Designer
{
    internal class ThemeFactory
    {
       
        public ThemeFactory()
        {
            
        }

        internal Theme getTheme(int selectedIndex)
        {
            Theme  theme = null;

            if (selectedIndex == 0)
            {
                theme =  new ThemeAzure();
            }

            if(selectedIndex == 1)
            {
               theme = new ThemeSalmon();
            }

            return theme;
        }
    }
}
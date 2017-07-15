using System.Collections;

namespace Designer
{
    class ThemeService :IThemeService
    {
        private ArrayList themeList = new ArrayList();

        public IList GetThemes()
        {
            
            themeList.Add(ThemeEnum.Theme);
            themeList.Add(ThemeEnum.AnotherTheme);
            return themeList;
        }

        

        
    }
}

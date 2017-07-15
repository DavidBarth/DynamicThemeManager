using System;
using System.Collections;

namespace Designer
{
    class ThemeService :IThemeService
    {
        private ArrayList themeList = new ArrayList();

        

        public IList GetThemes()
        {
            InitThemes();
            return themeList;
        }

        private void InitThemes()
        {
            themeList.Add(ThemeEnum.ThemeAzure);
            themeList.Add(ThemeEnum.ThemeSalmon);
        }



        public void ChangeTheme(int themeNumber)
        {
            throw new NotImplementedException();
        }

    }
}

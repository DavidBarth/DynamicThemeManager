using System.Collections;

namespace Designer
{
    class ThemeService : IThemeService
    {
        private ArrayList themes = new ArrayList();
        
        public ThemeService()
        {
            Init();
        }

        private void Init()
        {
            themes.Add(ThemeEnum.ThemeAzure);
            themes.Add(ThemeEnum.ThemeSalmon);
        }

        public ArrayList GetThemes()
        {
            return themes;
        }
    }
}

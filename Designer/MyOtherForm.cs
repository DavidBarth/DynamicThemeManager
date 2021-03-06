﻿using System.Windows.Forms;


namespace Designer
{
    public partial class MyOtherForm : Form
    {
        IThemeService service = new ThemeService();

        public MyOtherForm()
        {
            Init();           
        }

        private void Init()
        {
            InitializeComponent();
        }

        private void ShowMessageButton_MouseClick(object sender, MouseEventArgs e)
        {
            var source = service.GetThemes();
            comboBox1.DataSource = source;
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ThemeFactory themeFactory = new ThemeFactory();
            Theme selectedTheme = themeFactory.getTheme(comboBox1.SelectedIndex);

            toolStrip1.BackColor = selectedTheme.GetThemeColor();
            ChangeThemeButton.BackColor = selectedTheme.GetThemeColor();
        }

       

    }
}

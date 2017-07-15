using System.Windows.Forms;


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

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    toolStrip1.BackColor = System.Drawing.Color.LightSalmon;
                    button1.BackColor = System.Drawing.Color.LightSalmon;
                    break;

                case 1:
                    MessageBox.Show("Switch to theme 2");
                    break;
            }
        }
    }
}

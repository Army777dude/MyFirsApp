namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public object DisplayNUKE { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _button_Click(object sender, EventArgs e)
        {
            _nuke.Visible = true;
            _arrow.Visible = false;
            _button.Visible = false;
            _label1.Visible = false;
        }
    }
}

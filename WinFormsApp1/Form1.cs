namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MyEditForm form = new MyEditForm();
            form.Show();*/

            Form1 Form1 = new Form1();
            Form2.Show();
        }
    }
}
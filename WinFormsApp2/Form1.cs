namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m��terilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmM�steriler frm = new frmM�steriler();

            frm.MdiParent = this; //��inde bulundu�um ekran ana formu  form1 dir dedik burda
            frm.Show();
        }

       
    }
}

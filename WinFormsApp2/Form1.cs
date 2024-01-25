namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void müþterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler frm = new frmMüsteriler();

            frm.MdiParent = this; //Ýçinde bulunduðum ekran ana formu  form1 dir dedik burda
            frm.Show();
        }

       
    }
}

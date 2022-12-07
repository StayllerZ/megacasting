namespace MEGACASTING
{
    public partial class Form1 : Form
    {
        private Form activeForm;



        public Form1()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (childForm == null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelAccueil.Text = childForm.Text;


        }

        private void buttonCasting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Vues.Casting());
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Vues.Client());
        }

        private void buttonPartenaire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Vues.Partenaire());
        }


    }
}
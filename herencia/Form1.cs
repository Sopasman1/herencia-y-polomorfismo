using Herencia;
using Microsoft.VisualBasic.Devices;

namespace herencia
{
    public partial class Form1 : Form
    {
        private AudiS8Mk2 audi;
        private Lamborghini lambo;
        public Form1()
        {
            InitializeComponent();
            audi = new AudiS8Mk2();
            lambo = new Lamborghini();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Audi S8 Mk2:\n" + audi.Motor(), "Car Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Lamborghini:\n" + lambo.Motor(), "Car Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

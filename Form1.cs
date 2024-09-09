using PoC_Herencia_Polimorfismo.Clases;
using PoC_Herencia_Polimorfismo.Interfaces;

namespace PoC_Herencia_Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perro perro = new Perro();
            if (string.IsNullOrEmpty(txtPerro2.Text))
            {
                lblPerro2.Text = perro.EmitirOnomatopeya();
            }
            else
            {
                lblPerro2.Text = perro.EmitirOnomatopeya(txtPerro2.Text);
            }
        }

        private void btnGato2_Click(object sender, EventArgs e)
        {
            Gato gato = new Gato();
            if (string.IsNullOrEmpty(txtGato2.Text))
            {
                lblGato2.Text = gato.EmitirOnomatopeya();
            }
            else
            {
                lblGato2.Text = gato.EmitirOnomatopeya(txtGato2.Text);
            }
        }

        private void btnPerro_Click_1(object sender, EventArgs e)
        {
            Perro perro = new Perro();
            lblPerro.Text = perro.EmitirOnomatopeya();
        }

        private void btnGato_Click_1(object sender, EventArgs e)
        {
            Gato gato = new Gato();
            lblGato.Text = gato.EmitirOnomatopeya();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            IAnimal perro = new PerroPorInterfaz();
            lblPerro3.Text = perro.EmitirOnomatopeya();
        }

        private void btnGato3_Click(object sender, EventArgs e)
        {
            GatoPorInterfaz gato = new GatoPorInterfaz();
            lblGato3.Text = gato.EmitirOnomatopeya();
        }
    }
}
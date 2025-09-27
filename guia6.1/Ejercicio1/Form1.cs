using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular departamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           

            try
            {
                string nombre = tbNombre.Text;
                string patente = tbPatente.Text;
                int dni = Convert.ToInt32(tbDNI.Text);

                Persona persona = new Persona(dni, nombre);

                RegistroVehiculo registro = departamento.RegistrarVehiculo(persona, patente);

                tbNombre.Clear();
                tbPatente.Clear();
                tbDNI.Clear();
            }
            catch (FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show(ex.Message, "Patente no valida ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (RangoDniIncorrectoException ex)
            {
                MessageBox.Show(ex.Message, "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            departamento.Ordenar();

            for (int n=0;n<departamento.CantidadRegistros;n++)
            {
                RegistroVehiculo ver = departamento.VerRegistro(n);

                form2.listBox1.Items.Add(ver);

            }
            form2.ShowDialog();



        }
    }
}

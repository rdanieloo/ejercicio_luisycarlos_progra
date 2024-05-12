using System;
using System.Drawing;
using System.Windows.Forms;
using ejercicio_luisycarlos_progra.forms;


namespace ejercicio_luisycarlos_progra
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Simulación de una base de datos
        private readonly string userName = "admin";
        private readonly string userPass = "pass";

        private int counterInt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrEmpty(UserInputName.Text) || string.IsNullOrEmpty(UserInputPass.Text))
            {
                MessageBox.Show("Usuario y/o contraseña vacíos");
                return;
            }

            // Validación de nombre de usuario y contraseña
            if (userName.Equals(UserInputName.Text.ToLowerInvariant()) && userPass.Equals(UserInputPass.Text))
            {
                // Si las credenciales son válidas, muestra el formulario de registro
                FormRegistro registro = new FormRegistro();
                UserInputName.Text = null;
                UserInputPass.Text = null;
                counterInt = 0;
                registro.Show();
            }
            else
            {
                // Si las credenciales son inválidas, incrementa el contador de intentos
                counterInt++;
                MessageBox.Show("Usuario y/o contraseña inválidos");
            }

            // Si se exceden los intentos permitidos, cierra la aplicación
            if (counterInt >= 3)
            {
                MessageBox.Show("Se excedió el número de intentos permitidos. La aplicación se cerrará.");
                Application.Exit();
            }

            // Actualiza el contador de intentos en la interfaz
            counter.Text = counterInt.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

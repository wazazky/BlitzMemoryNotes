// Importación de bibliotecas necesarias para la aplicación
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlitzMemoryNotes
{
    public partial class FormPrincipal : MaterialForm
    {
        // Constructor del formulario
        public FormPrincipal()
        {
            InitializeComponent();
            // Inicialización de MaterialSkin
            IniMaterial();
        }

        // Método para inicializar MaterialSkin con el tema claro
        private void IniMaterial()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        // Método para inicializar MaterialSkin con el tema oscuro
        private void IniMaterial_NM()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        // Evento que se dispara cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ocultar los RichTextBox de destino al cargar el formulario
            targetRTB_1L.Visible = false;
            targetRTB_2L.Visible = false;
        }

        // Evento que se dispara cuando el texto del RichTextBox de origen cambia
        private void SourceRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Copiar las primeras y últimas letras de cada palabra al RichTextBox de destino
            string copiedText = CopyFirstAndLastLetters(sourceRichTextBox.Text);
            targetRTB_2L.Text = copiedText;

            // Copiar la primera letra de cada palabra al RichTextBox de destino
            copiedText = CopyFirstLetter(sourceRichTextBox.Text);
            targetRTB_1L.Text = copiedText;

            // Limpiar los RichTextBox de validación
            validationRTB_1L.Text = String.Empty;
            validationRTB_2L.Text = String.Empty;
        }

        // Método para copiar las primeras y últimas letras de cada palabra
        private string CopyFirstAndLastLetters(string text)
        {
            // Utilizar expresiones regulares para reemplazar el texto
            return Regex.Replace(text, @"\b(?![0-9]+)(\w)\w*(\w)\b", "$1$2");
        }

        // Método para copiar solo la primera letra de cada palabra
        private string CopyFirstLetter(string text)
        {
            // Utilizar expresiones regulares para reemplazar el texto
            return Regex.Replace(text, @"\b(?![0-9]+)(\w)\w*(\w)\b", "$1");
        }

        // Método para comparar dos strings hasta la longitud del más corto
        private bool CompareStringsUntilLength(string str1, string str2)
        {
            // Obtener la longitud del segundo string
            int length = Math.Min(str1.Length, str2.Length);

            // Obtener una subcadena del primer string con la misma longitud que el segundo
            string subStr1 = str1.Substring(0, length);

            // Comparar las subcadenas
            return subStr1.Equals(str2);
        }

        // Evento que se dispara cuando el texto del RichTextBox de validación cambia
        private void ValidationRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Comparar el texto del RichTextBox de destino con el de validación
            if (CompareStringsUntilLength(targetRTB_2L.Text, validationRTB_2L.Text))
            {
                System.Console.WriteLine("Si es igual");
                validationRTB_2L.ForeColor = Color.Green;
                UpdateProgress(targetRTB_2L.Text, validationRTB_2L.Text, progressBarL2);
            }
            else
            {
                System.Console.WriteLine("no es igual");
                validationRTB_2L.ForeColor = Color.Red;
            }
        }

        // Evento que se dispara cuando el texto del RichTextBox de validación para la primera letra cambia
        private void ValidationRTB_L1_TextChanged(object sender, EventArgs e)
        {
            // Comparar el texto del RichTextBox de destino con el de validación
            if (CompareStringsUntilLength(targetRTB_1L.Text, validationRTB_1L.Text))
            {
                System.Console.WriteLine("Si es igual");
                validationRTB_1L.ForeColor = Color.Green;
                UpdateProgress(targetRTB_1L.Text, validationRTB_1L.Text, progressBarL1);
            }
            else
            {
                System.Console.WriteLine("no es igual");
                validationRTB_1L.ForeColor = Color.Red;
            }
        }

        // Método para actualizar el progreso en el ProgressBar
        public void UpdateProgress(string str1, string str2, System.Windows.Forms.ProgressBar progressBar)
        {
            progressBar.Maximum = str1.Length;
            progressBar.Value = str2.Length;

            // Si los textos son iguales y no están vacíos, mostrar un mensaje de felicitación
            if (str2 == str1 && str1.Length != 0)
            {
                MessageBox.Show("Bien Hecho", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabPage1.Focus();
            }
        }

        // Evento que se dispara cuando el RichTextBox de origen pierde el foco
        private void SourceRichTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceRichTextBox.Text))
            {
                sourceRichTextBox.Text = "Escribe o pega la informacion que quieres memorizar";
                sourceRichTextBox.ForeColor = Color.LightGray;
            }
        }

        // Evento que se dispara cuando el RichTextBox de origen gana el foco
        private void sourceRichTextBox_Enter(object sender, EventArgs e)
        {
            if (sourceRichTextBox.Text == "Escribe o pega la informacion que quieres memorizar")
            {
                sourceRichTextBox.Text = "";
                sourceRichTextBox.ForeColor = Color.Black;
            }
        }

        // Evento que se dispara cuando el estado del Switch cambia (para el tema oscuro)
        private void Switch_NM_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch_NM.Checked)
            {
                IniMaterial_NM();
            }
            else
            {
                IniMaterial();
            }
        }

        // Evento que se dispara al hacer clic en el botón para borrar el texto de origen
        private void FAButton_Borrar_Base_Click(object sender, EventArgs e)
        {
            sourceRichTextBox.Text = string.Empty;
        }

        // Evento que se dispara al hacer clic en el botón para borrar el texto de validación (2L)
        private void FAButton_Borrar_2L_Click(object sender, EventArgs e)
        {
            validationRTB_2L.Text = string.Empty;
        }

        // Evento que se dispara al hacer clic en el botón para borrar el texto de validación (1L)
        private void FAButton_Borrar_1L_Click(object sender, EventArgs e)
        {
            validationRTB_1L.Text = string.Empty;
        }

        // Evento que se dispara al hacer clic en el botón para abrir el formulario QR
        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormQR formulario = new FormQR();
            formulario.TSource = sourceRichTextBox.Text;
            formulario.T2L = validationRTB_2L.Text;
            formulario.T1L = validationRTB_1L.Text;
            formulario.Show();
        }

        // Evento que se dispara cuando el estado del Switch cambia (para mostrar/ocultar targetRTB_1L)
        private void materialSwitch_tb2_CheckedChanged(object sender, EventArgs e)
        {
            targetRTB_1L.Visible = materialSwitch_tb2.Checked;
        }

        // Evento que se dispara cuando el estado del Switch cambia (para mostrar/ocultar targetRTB_2L)
        private void materialSwitch_tb1_CheckedChanged(object sender, EventArgs e)
        {
            targetRTB_2L.Visible = materialSwitch_tb1.Checked;
        }
    }
}


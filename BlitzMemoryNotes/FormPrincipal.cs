﻿using MaterialSkin;
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
        public FormPrincipal()
        {
            InitializeComponent();
            //progressBarL1.MaximumSize = targetRTB_1L.Size;
            IniMaterial();
        }
        private void IniMaterial() {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void IniMaterial_NM()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SourceRichTextBox_TextChanged(object sender, EventArgs e)
        {
            string copiedText = CopyFirstAndLastLetters(sourceRichTextBox.Text);
            targetRTB_2L.Text = copiedText;
            copiedText = CopyFirstLetter(sourceRichTextBox.Text);
            targetRTB_1L.Text = copiedText;
            validationRTB_1L.Text = String.Empty;
            validationRTB_2L.Text = String.Empty;
        }
        private string CopyFirstAndLastLetters(string text)
        {
            // Utilizar expresiones regulares para reemplazar el texto
            return Regex.Replace(text, @"\b(?![0-9]+)(\w)\w*(\w)\b", "$1$2");
        }
        private string CopyFirstLetter(string text)
        {
            // Utilizar expresiones regulares para reemplazar el texto
            return Regex.Replace(text, @"\b(?![0-9]+)(\w)\w*(\w)\b", "$1");
        }
        //private bool ContainsErrors(string text)
        //{
        //    // Puedes definir aquí tu propia lógica para determinar si el texto contiene errores.
        //    // Por ejemplo, puedes verificar si hay palabras mal escritas o si no se ha completado cierta estructura.
        //    // Por ahora, esta función devuelve true si el texto está vacío.
        //    return string.IsNullOrWhiteSpace(text);
        //}
        private bool CompareStringsUntilLength(string str1, string str2)
        {
            // Obtener la longitud del segundo string
            int length = Math.Min(str1.Length, str2.Length);

            // Obtener una subcadena del primer string con la misma longitud que el segundo
            string subStr1 = str1.Substring(0, length);

            // Comparar las subcadenas
            return subStr1.Equals(str2);
        }

        private void ValidationRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CompareStringsUntilLength(targetRTB_2L.Text, validationRTB_2L.Text) == true)
            {
                System.Console.WriteLine("Si es igual");
                validationRTB_2L.ForeColor = Color.Green;
                UpdateProgress(targetRTB_2L.Text, validationRTB_2L.Text, progressBarL2);
            }
            else
            { System.Console.WriteLine("no es igual"); 
            validationRTB_2L.ForeColor = Color.Red;
            }
        }

        private void ValidationRTB_L1_TextChanged(object sender, EventArgs e)
        {
            if (CompareStringsUntilLength(targetRTB_1L.Text, validationRTB_1L.Text) == true)
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

        public void UpdateProgress(string str1, string str2,System.Windows.Forms.ProgressBar progressBar)
        {   
            progressBar.Maximum=str1.Length;
            progressBar.Value =str2.Length ;

            if (str2==str1) {
              MessageBox.Show("Bien Hecho", "Correcto");
                tabPage1.Focus();
            }
        }

       
        private void SourceRichTextBox_Leave(object sender, EventArgs e)
        {
            if (sourceRichTextBox.Text == "") {
                sourceRichTextBox.Text = "Escribe o pega la informacion que quieres memorizar";
                sourceRichTextBox.ForeColor = Color.LightGray;

            }
        }

        private void sourceRichTextBox_Enter(object sender, EventArgs e)
        {
            if (sourceRichTextBox.Text == "Escribe o pega la informacion que quieres memorizar")
            {
                sourceRichTextBox.Text = "";

                sourceRichTextBox.ForeColor = Color.Black;

            }
        }

        private void Switch_NM_CheckedChanged(object sender, EventArgs e)
        {
            if (Switch_NM.Checked == true)
            {
                IniMaterial_NM();
            }
            if (Switch_NM.Checked == false)
            {
                IniMaterial();

            }
        }

        private void FAButton_Borrar_Base_Click(object sender, EventArgs e)
        {
            sourceRichTextBox.Text=string.Empty;
        }

        private void FAButton_Borrar_2L_Click(object sender, EventArgs e)
        {
            validationRTB_2L.Text = string.Empty;
        }

        private void FAButton_Borrar_1L_Click(object sender, EventArgs e)
        {
            validationRTB_1L.Text = string.Empty;   
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormQR formulario = new FormQR();

            // Mostrar el formulario
            formulario.Show();
        }
    }
}

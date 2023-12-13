using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursividadFormsPorKEY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ListFilesRecursively(string directoryPath)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directoryPath))
                {
                    listBox1.Items.Add($"Archivo: {Path.GetFileName(file)}, Extensión: {Path.GetExtension(file)}");
                }

                foreach (string subdirectory in Directory.GetDirectories(directoryPath))
                {
                    ListFilesRecursively(subdirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al acceder a {directoryPath}: {ex.Message}");
            }
        }

        private void explore_Click_1(object sender, EventArgs e)
        {
            string directoryPath = @"C:\Users\junio\OneDrive\Escritorio"; // Cambia esto a la ruta del directorio que desees explorar
            listBox1.Items.Clear();
            ListFilesRecursively(directoryPath);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimulacroParcial1
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes = new List<Estudiante>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarEstudiantes()
        {
            estudiantes.Clear();

            string[] lineas = File.ReadAllLines("estudiantes.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                Estudiante e = new Estudiante(datos[0], datos[1], datos[2]);

                estudiantes.Add(e);
            }
        }
        private void CargarTalleres()
        {
            string[] lineas = File.ReadAllLines("talleres.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                Taller t = new Taller(
                    datos[0],
                    datos[1],
                    Convert.ToDouble(datos[2])
                );

                talleres.Add(t);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarTalleres();

            foreach (Estudiante e1 in estudiantes)
            {
                comboBoxEstudiantes.Items.Add(e1.Nombre);
            }

            foreach (Taller t in talleres)
            {
                comboBoxTalleres.Items.Add(t.Nombre);
            }
        }
    }
}

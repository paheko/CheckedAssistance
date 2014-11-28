using GenerarCodigos.DAO;
using GenerarCodigos.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarCodigos.FORM
{
    public partial class Asistencia : Form
    {
        List<DTOAsistencia> asistenciaTotal = new List<DTOAsistencia>();
        public Asistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de agregar este día?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
               == DialogResult.Yes) 
            {
                dateTimePicker1.Enabled=false;
                codigo_textbox.Enabled = true;
            }
        }

        private void por_nombre_button_Click(object sender, EventArgs e)
        {
            nombre_textbox.Enabled = true;
            codigo_textbox.Enabled = false;
        }

        private void asistencia_button_Click(object sender, EventArgs e)
        {
            nombre_textbox.Enabled = false;
            codigo_textbox.Enabled = true;
            if (AsistenciaRepetida(codigo_textbox.Text))
            {
                MessageBox.Show("Alumno con asistencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codigo_textbox.Text = null;
            }
            else
            {
                //Registramos la asistencia
                DTOAsistencia asistencia = new DTOAsistencia();
                //asistencia.id = dateTimePicker1;
                asistencia.codigo_alumno = codigo_textbox.Text;
                new DAOAsistencia().InsertAsistencia(asistencia);
                asistenciaTotal.Add(asistencia);
                codigo_textbox.Text = null;
            }
        }

        private void codigo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int cantidad;
                if (!int.TryParse(codigo_textbox.Text, out cantidad))
                {
                    MessageBox.Show("Debes ingresar un número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigo_textbox.Text = null;
                }
                else if (codigo_textbox.Text.Equals(' ') || codigo_textbox.Text.Equals(null))
                {
                    MessageBox.Show("No debes ingresar espacios en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigo_textbox.Text = null;
                }
                else if(AsistenciaRepetida(codigo_textbox.Text))
                {
                    MessageBox.Show("Alumno con asistencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codigo_textbox.Text = null;
                }
                else 
                {
                    nombre_textbox.Text = null;
                    grado_textbox.Text = null;
                    catecismo_textbox.Text = null;
                    //Registramos la asistencia
                    DTOAsistencia asistencia = new DTOAsistencia();
                    asistencia.id = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(dateTimePicker1.Value));
                    asistencia.codigo_alumno = codigo_textbox.Text;
                    new DAOAsistencia().InsertAsistencia(asistencia);
                    asistenciaTotal.Add(asistencia);
                    DTOAlumnos alumno = new DTOAlumnos();
                    alumno = new DAOAlumnos().GetAlumno(codigo_textbox.Text);
                    nombre_textbox.Text = alumno.Nombre;
                    grado_textbox.Text = alumno.grado;
                    catecismo_textbox.Text = alumno.catecismo;
                    codigo_textbox.SelectionStart = 0;
                    codigo_textbox.SelectionLength = codigo_textbox.Text.Length;
                }
            }
        }

        public bool AsistenciaRepetida(string codigo) 
        {
            bool repetido = false;
            //for each donde recorre la lista para saber si ya esta registrado el niño
            foreach(DTOAsistencia temp in asistenciaTotal)
            {
                if(temp.codigo_alumno.Equals(codigo))
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }
    }
}

using GenerarCodigos.DAO;
using GenerarCodigos.FORM;
using punto_venta;
using punto_venta.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace GenerarCodigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarCodigos_button_Click(object sender, EventArgs e)
        {
            //Creo una lista de todos los alumnos para realizar el codig

            //Genero el codigo dentro de un foreach

            //Contenido dentro de foreach
            List<DTOAlumnos> alumnos = new List<DTOAlumnos>();
            alumnos=new DAOAlumnos().GetAlumnos();
            foreach(DTOAlumnos lista in alumnos)
            {
                Code39 code = new Code39(lista.codigo);


                string pathString2 = @"c:\Codigos generados";
                string nombreArchivo = lista.codigo+"-"+lista.Nombre+"-"+lista.catecismo+"-"+lista.grado;
                if (!System.IO.File.Exists(pathString2))
                {
                    System.IO.Directory.CreateDirectory(pathString2);
                  
                    code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                    // Load the image.
                    //System.Drawing.Image image1 = System.Drawing.Image.FromFile(@"C:\Codigos generados"+ "\\" + nombreArchivo + ".png");

                    // Save the image in JPEG format.
                    //image1.Save(@"C:\Codigos generados" + "\\" + nombreArchivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                   // Image img = Image.FromFile("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                  //  img.Save("c:\\Codigos generados2" + "\\" + nombreArchivo + "2" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                  //  Bitmap customImage = new Bitmap(@"c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                   // transformacionesElementales elementales = new transformacionesElementales(customImage);
                    //elementales.descomponerRGB();
                   // elementales.binarizacion(128);
                    //elementales.componerRGB();
                   // Graphics g = Graphics.FromImage(customImage);
                    //g.DrawImage(customImage, 0, 0, customImage.Width, customImage.Height);
                    //customImage.MakeTransparent();
                    //g.DrawImage(customImage, customImage.Width, 0,
                      //customImage.Width, customImage.Height);
                    //customImage.Save("c:\\Codigos generados" + "\\" + nombreArchivo + "MOD" + ".png");
                    //g.DrawString(lista.Nombre, new Font("Verdana", 12, GraphicsUnit.Pixel), new SolidBrush(Color.Red), 10, 90);
                    //elementales.getMapa().Save("c:\\Codigos generados" + "\\" + nombreArchivo+"2"+ ".png");
                }
                else
                {
                   
                  code.Paint().Save("c:\\Codigos generados" + "\\" + nombreArchivo + ".png", ImageFormat.Png);
                  // Load the image.
                  //System.Drawing.Image image1 = System.Drawing.Image.FromFile(@"C:\Codigos generados" + "\\" + nombreArchivo + ".png");

                  // Save the image in JPEG format.
                  //image1.Save(@"C:\Codigos generados" + "\\" + nombreArchivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                  //  Image img = Image.FromFile("c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                //    img.Save("c:\\Codigos generados2" + "\\" + nombreArchivo + "2"+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                   // Bitmap customImage = new Bitmap(@"c:\\Codigos generados" + "\\" + nombreArchivo + ".png");
                   // transformacionesElementales elementales = new transformacionesElementales(customImage);
                    //elementales.descomponerRGB();
                   // elementales.binarizacion(128);
                    //elementales.componerRGB();
                    /*Graphics g = Graphics.FromImage(customImage);
                    g.DrawImage(customImage, 0, 0, customImage.Width, customImage.Height);
                    customImage.MakeTransparent();
                    g.DrawImage(customImage, customImage.Width, 0,
                      customImage.Width, customImage.Height);
                    customImage.Save("c:\\Codigos generados" + "\\" + nombreArchivo + "MOD" + ".png");*/
                    //Graphics g = Graphics.FromImage(elementales.getMapa());
                    //g.DrawString(lista.Nombre, new Font("Verdana", 12, GraphicsUnit.Pixel), new SolidBrush(Color.Red), 10, 90);
                    //elementales.getMapa().Save("c:\\Codigos generados" + "\\" + nombreArchivo+"2"+ ".png");
                }
            }
         }

        private void importar_button_Click(object sender, EventArgs e)
        {
            Importar_Exportar_form ventana = new Importar_Exportar_form();
            ventana.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            List<DTOAlumnos> alumnos = new List<DTOAlumnos>();
            alumnos=new DAOAlumnos().GetAlumnos();
            this.dataGridView1.DataSource = alumnos.ToArray();
        }

        private void borrar_button_Click(object sender, EventArgs e)
        {
            List<DTOAlumnos> alumnos = new List<DTOAlumnos>();
            alumnos = new DAOAlumnos().GetAlumnos();
            foreach(DTOAlumnos temp in alumnos)
            {
                new DAOAlumnos().DeleteAlumno(temp.codigo);
            }
            alumnos = new DAOAlumnos().GetAlumnos();
            this.dataGridView1.DataSource = alumnos.ToArray();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Asistencia ventana = new Asistencia();
            ventana.ShowDialog();
        }
    }
}

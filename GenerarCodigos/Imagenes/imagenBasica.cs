using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class imagenBasica
    {
        protected int[,] pixeles;
        protected Bitmap mapa;
        public imagenBasica() { }
        public void setMapa(Bitmap mapa)
        {
            this.mapa = mapa;
            pixeles = new int[mapa.Width, mapa.Height];
            for (int j = 0; j < mapa.Height; j++)
            {
                for (int i = 0; i < mapa.Width; i++)
                {
                    pixeles[i, j] = mapa.GetPixel(i, j).ToArgb();
                }
            }
        }
        public Bitmap getMapa()
        {
            mapa = new Bitmap(pixeles.GetLength(0), pixeles.GetLength(1), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int j = 0; j < pixeles.GetLength(1); j++)
            {
                for (int i = 0; i < pixeles.GetLength(0); i++)
                {
                    mapa.SetPixel(i, j, Color.FromArgb(pixeles[i, j]));
                }
            }

            return mapa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class transformacionesElementales : imagenBasica
    {
        private int[,] R;
        private int[,] G;
        private int[,] B;

        public transformacionesElementales(Bitmap mapa)
        {
            setMapa(mapa);
        }   


        public void descomponerRGB()
        {
            R = new int[pixeles.GetLength(0), pixeles.GetLength(1)];
            G = new int[pixeles.GetLength(0), pixeles.GetLength(1)];
            B = new int[pixeles.GetLength(0), pixeles.GetLength(1)];
            for (int i = 0; i < pixeles.GetLength(1); i++)
            {
                for (int j = 0; j < pixeles.GetLength(0); j++)
                {
                    R[j, i] = (pixeles[j, i] & 0X00ff0000) >> 16;
                    G[j, i] = (pixeles[j, i] & 0x0000ff00) >> 8;
                    B[j, i] = (pixeles[j, i] & 0X000000ff);
                }
            }
        }

        public void componerRGB()
        {
            pixeles = new int[R.GetLength(0), R.GetLength(1)];

            for (int j = 0; j < pixeles.GetLength(1); j++)
            {
                for (int i = 0; i < pixeles.GetLength(0); i++)
                {
                   pixeles[i, j] = (255 << 24 | R[i, j] << 16 | G[i, j] << 8 | B[i, j]);
                }
            }


        }

        public void escalaDeGrises() 
        {
            int x;
            for (int i = 0; i < pixeles.GetLength(1); i++)
            {
                for (int j = 0; j < pixeles.GetLength(0); j++)
                {
                    x=(R[j,i]+G[j,i]+B[j,i])/3;
                    R[j,i]=x;
                    G[j,i]=x;
                    B[j, i] = x;
                    //pixeles[j, i] = (255 << 24 | R[j, i] << 16 | G[j, i] << 8 | B[j, i]);
                    
                }
            }
        }

        public void binarizacion(int x) 
        {
           
            for (int i = 0; i < pixeles.GetLength(1); i++)
            {
                for (int j = 0; j < pixeles.GetLength(0); j++)
                {
                   
                    if (R[j, i] > x)
                    {
                        R[j, i] = 255;
                        G[j, i] = 255;
                        B[j, i] = 255;
                    }
                    else 
                    {
                        R[j, i] = 0;
                        G[j, i] = 0;
                        B[j, i] = 0;
                    }                                    

                }
            }
        }
        public int[,] ObtenerMatrizPixeles(Bitmap mapa)
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
            return pixeles;
        }
    }
}

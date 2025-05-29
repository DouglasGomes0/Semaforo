using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timTemporizador.Stop();
        }
        private int estado;
        private void timTemporizador_Tick(object sender, EventArgs e)
        {
            
            
             estado++; 
                

                if (estado == 1)
                {
                    pibVermelho.Visible = true;
                    pibAmarelo.Visible = false;
                    pibVerde.Visible = false;
                    
                }
                if (estado == 2)
                {
                    pibVermelho.Visible = false;
                    pibAmarelo.Visible = false;
                    pibVerde.Visible = true;
                    
                }
                if (estado == 3)
                {
                    pibVermelho.Visible = false;
                    pibAmarelo.Visible = true;
                    pibVerde.Visible = false;
                    estado = 0;

                }
            
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            timTemporizador.Start();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            timTemporizador.Stop();
            pibVermelho.Visible = false;
            pibAmarelo.Visible = false;
            pibVerde.Visible = false;
        }
    }
}

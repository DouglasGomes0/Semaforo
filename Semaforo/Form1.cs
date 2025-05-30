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
            timTemporizador.Stop(); //para o timer começar desligado\\
        }
        private int estado;
        private void timTemporizador_Tick(object sender, EventArgs e)
        {
            
            
             estado++; 
                

                if (estado == 1) //o estado 1 remete ao primeiro tick\\
                {
                    pibVermelho.Visible = true;
                    pibAmarelo.Visible = false;
                    pibVerde.Visible = false;
                    
                }
                if (estado == 2)//o estado 2 remete ao segundo tick\\
                {
                    pibVermelho.Visible = false;
                    pibAmarelo.Visible = false;
                    pibVerde.Visible = true;
                    
                }
                if (estado == 3)//o estado 3 remete ao terceiro tick\\
                {
                    pibVermelho.Visible = false;
                    pibAmarelo.Visible = true;
                    pibVerde.Visible = false;
                    estado = 0;//retornar ao primeiro tick, fazendo loop\\

                }
            
        }

        private void btnLigar_Click(object sender, EventArgs e)//botão para começar o timer\\
        {
            timTemporizador.Start();
        }

        private void btnDesligar_Click(object sender, EventArgs e)//botão que para o timer\\
        {
            //para remover as cores do semáforo ao parar\\
            timTemporizador.Stop();
            pibVermelho.Visible = false;
            pibAmarelo.Visible = false;
            pibVerde.Visible = false;
        }
    }
}

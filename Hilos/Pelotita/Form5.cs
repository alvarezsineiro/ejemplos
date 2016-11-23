using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pelotita
{
    public partial class Form5 : Form
    {
        List<Thread> _hilos;
        int _cantpausados;
        public Form5()
        {

            InitializeComponent();
            this._hilos = new List<Thread>();
            this._cantpausados = 0;

            this.btncrear.Click += new EventHandler(this.crear);
            this.btndestruir.Click += new EventHandler(this.destruir);
            this.btnreanudar.Click += new EventHandler(this.resume);

        }

        private void btnpausar_Click(object sender, EventArgs e)
        {
            try
            {
                this._hilos[_hilos.Count-1].Suspend();
                this._cantpausados++;
            }
            catch (Exception)
            {
               
            }
           

        }
        private void crear(object sender, EventArgs e)
        { 
            Pelotita_con_thread.Pelotita nuevapelotita = new Pelotita_con_thread.Pelotita(pictureBox1);
            Thread mihilo = new Thread(nuevapelotita.DoWork);
            this._hilos.Add(mihilo);
            mihilo.Start();
        }
        private void destruir(object sender, EventArgs e)
        {
            try
            {
                this._hilos[_hilos.Count - 1].Abort();
                this._hilos.RemoveAt(_hilos.Count - 1);

                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(pictureBox1.BackColor);
            }
            catch (Exception)
            {

            }
        }

        private void resume(object sender, EventArgs e)
        {
            try
            {
                this._hilos[_cantpausados - 1].Resume();
                this._cantpausados--;
            }
            catch (Exception)
            {

            }
        }
    }
}

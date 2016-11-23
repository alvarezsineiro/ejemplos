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
    public partial class Form4 : Form
    {
        Thread _mihilo;
        public Form4()
        {
            InitializeComponent();
            this.btndestruir.Click += new EventHandler(this.destruir);
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            Pelotita_con_thread.Pelotita nuevapelotita = new Pelotita_con_thread.Pelotita(pictureBox1);
            this._mihilo = new Thread(nuevapelotita.DoWork);
            this._mihilo.Start();

            this.btncrear.Click -= new System.EventHandler(this.btncrear_Click);
        }

        private void btnpausar_Click(object sender, EventArgs e)
        {

            this._mihilo.Suspend();
            
        }
        
        private void btndestruir_Click(object sender, EventArgs e)
        {
            
        }
        private void destruir(object sender, EventArgs e)
        {
            this._mihilo.Resume();
            this._mihilo.Abort();
        }
    }
}

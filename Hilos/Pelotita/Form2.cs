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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            Pelotita_con_thread.Pelotita nuevapelotita = new Pelotita_con_thread.Pelotita(pictureBox1);
            Thread nuevohilo = new Thread(nuevapelotita.DoWork);
            nuevohilo.Start();
        }
    }
}

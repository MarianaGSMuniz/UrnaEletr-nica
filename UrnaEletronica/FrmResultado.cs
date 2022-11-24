using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class FrmResultado : Form
    {
        public FrmResultado(int mario, int batman, int barbie, int branco)
        {
            InitializeComponent();
            lblmario.Text = mario.ToString();
            lblbatman.Text = batman.ToString();
            lblbarbie.Text = barbie.ToString();
            lblBranco.Text = branco.ToString();
        }
    }
}

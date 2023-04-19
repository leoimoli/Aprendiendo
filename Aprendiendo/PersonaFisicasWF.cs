using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendiendo
{
    public partial class PersonaFisicasWF : Form
    {
        public PersonaFisicasWF()
        {
            InitializeComponent();
        }

        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            AltaPersonaWF _altaPersona = new AltaPersonaWF();
            _altaPersona.Show();
            Hide();
        }
    }
}

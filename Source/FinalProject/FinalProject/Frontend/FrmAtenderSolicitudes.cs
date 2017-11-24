using FinalProject.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Frontend
{
    public partial class FrmAtenderSolicitudes : Form
    {
        private Tutor tutor = null;
        public FrmAtenderSolicitudes(Tutor tutor)
        {
            InitializeComponent();

            this.tutor = tutor;
        }


    }
}

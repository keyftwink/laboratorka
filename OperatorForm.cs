using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorka
{
    public partial class OperatorForm : Form
    {

        DataBase dataBase = new DataBase();
        private readonly CheckUser user;

        public OperatorForm(CheckUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}

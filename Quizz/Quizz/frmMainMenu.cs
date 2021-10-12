using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class frmMainMenu : Form
    {
        private frmQuizz quizz;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(!NameEmpty)
            {
                quizz = new frmQuizz();
                quizz.Show();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtName.Text);
            lblNameNotValid.Visible = NameEmpty;
        }

        private bool NameEmpty => txtName.Text == string.Empty ? true : false;
    }
}

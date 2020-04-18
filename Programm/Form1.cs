using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programm
{
    public partial class Form1 : Form
    {
        private ReplaceHelper replaceHelper = new ReplaceHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            replaceHelper.textOriginal = textBoxReplaced.Text;
            textBoxReplaced.Text = replaceHelper.getReplacedText();
        }
    }
}

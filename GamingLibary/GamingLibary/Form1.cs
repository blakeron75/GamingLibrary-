using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamingLibary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                webBrowser1.Navigate("https://www.google.com/search?site=&source=hp&q=" + textBox1.Text);
            else if (radioButton2.Checked == true)
                webBrowser1.Navigate("https://www.google.com/search?hl=en&site=imghp&tbm=isch&source=hp&biw=1372&bih=669&q=" + textBox1.Text);
            else if (radioButton3.Checked == true)
                webBrowser1.Navigate("https://www.amazon.com/s/ref=nb_sb_noss_1/131-9851296-0465633?url=search-alias%3Daps&field-keywords=" + textBox1.Text);
            else if (radioButton4.Checked == true)
                webBrowser1.Navigate("https://www.youtube.com/results?search_query=" + textBox1.Text);
            else if (radioButton5.Checked == true)
                webBrowser1.Navigate("http://www.gamestop.com/browse?nav=16k-3-" + textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void online_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

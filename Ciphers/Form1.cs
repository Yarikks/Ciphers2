using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciphers
{
    public partial class Form1 : Form
    {
        Transposition t = new Transposition();
        Blocks b = new Blocks();
        TableRoad tb = new TableRoad();
        public Form1()
        {
            InitializeComponent();
        }

        private void Simple_Click(object sender, EventArgs e)
        {
            t.SetKey(key.Text);
            cipheredText.Text = t.Encrypt(cipherText.Text);
        }

        private void Blocked_Click(object sender, EventArgs e)
        {
            string[] ninput = Regex.Split(cipherText.Text, @"(?<=\G.{4})");
            b.SetKey(key.Text);
            for(int i = 0; i < ninput.Length; i++)
            {
                cipheredText.Text += b.Encrypt(ninput[i]);
            }

        }

        private void Tabled_Click(object sender, EventArgs e)
        {
            cipheredText.Text = tb.Encrypt(cipherText.Text, key.Text);
        }

        private void Verticle_Click(object sender, EventArgs e)
        {
            cipheredText.Text = Vertical.Encrypt(cipherText.Text, key.Text);
        }
    }
}

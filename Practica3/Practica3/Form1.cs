using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                string nombre = font.Name;
                comboBox1.Items.Add(nombre);
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string text = comboBox1.Items[e.Index].ToString();
            Font font = new Font(text, e.Font.Size);

            e.Graphics.DrawString(text, font, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);

            e.DrawFocusRectangle();
        }
    }
}

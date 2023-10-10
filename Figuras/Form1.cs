using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            string message = "El resultado es " + CreateShape().Area();
            MessageBox.Show(message, "Resultado");
        }

        private void rRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ActivateControls(new List<Control>() { lHeight, lWidth, tHeight, tWidth });
        }

        private void rCircle_CheckedChanged(object sender, EventArgs e)
        {
            ActivateControls(new List<Control>() { lRadio,tRadius });
        }

        private void rTriangle_CheckedChanged(object sender, EventArgs e)
        {
            ActivateControls(new List<Control>() {lSide,tSide });
        }

        private void ActivateControls(List<Control> controls)
        {
            foreach(Control control in groupBox2.Controls)
            {
                if (controls.Contains(control))
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bPerimeter_Click(object sender, EventArgs e)
        {
            string message = "El resultado es " + CreateShape().Perimeter();
            MessageBox.Show(message, "Resultado");
        }

        private Shape CreateShape()
        {
             Shape shape;
            
            if(rCircle.Checked)
            {
                shape = new Circle(float.Parse(tRadius.Text));
            }
            else if (rTriangle.Checked)
            {
                shape = new Triangle(float.Parse(tSide.Text));
            }
            else
            {
                shape = new Rectangle(float.Parse(tHeight.Text), float.Parse(tWidth.Text));
            }
            return shape;
        }
    }
}

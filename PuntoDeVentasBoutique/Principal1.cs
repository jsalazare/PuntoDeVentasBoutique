using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentasBoutique
{
    public partial class Principal1 : Form
    {
        private Button button1;
    
        public Principal1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal1
            // 
            this.ClientSize = new System.Drawing.Size(422, 319);
            this.Controls.Add(this.button1);
            this.Name = "Principal1";
            this.Text = "cacaca";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

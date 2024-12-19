using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14fi_class_with_minimal_responsives
{
    public class Christmasspresent:UserControl
    {
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label1;

        public string Name { get; private set; }    // set: írás
        public int Price { get; set; }
        public Christmasspresent(string name, int price)
        {
            InitializeComponent();
            Name = name;
            Price = price;
            label1.Text += Name;
            button1.Click += InfoEvent;
            button2.Click += DeleteEvent;
        }
        void DeleteEvent(Object s, EventArgs e)
        {
            Form1.AllChristmasspresent.Remove(this);
            this.Dispose();
        }
        void InfoEvent(Object s, EventArgs e)
        {
            MessageBox.Show($"Name of the presentt: {Name}, price of the present: {Price}");
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the present:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price of the present:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(304, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Christmasspresents
            // 
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Christmasspresents";
            this.Size = new System.Drawing.Size(391, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

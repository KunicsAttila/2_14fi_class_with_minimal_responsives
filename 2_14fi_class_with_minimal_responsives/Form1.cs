using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace _2_14fi_class_with_minimal_responsives
{
    public partial class Form1 : Form
    {
        public static ObservableCollection<Christmasspresent> AllChristmasspresent = new ObservableCollection<Christmasspresent>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            button1.Click += AddEvent;
            AllChristmasspresent.CollectionChanged += RestockEvent;
        }
        void RestockEvent(Object s, EventArgs e)
        {
            int num = 0;
            foreach (Christmasspresent item in AllChristmasspresent)
            {
                item.Top = num * item.Height + 15;
                num++;
            }
        }
        void AddEvent(Object s, EventArgs e)
        {
            if (textBox1.Text.Length > 1 && textBox2.Text.Length > 1)
            {
                try
                {
                    Christmasspresent onePresent = new Christmasspresent(textBox1.Text, int.Parse(textBox2.Text));
                    AllChristmasspresent.Add(onePresent);
                    groupBox1.Controls.Add(onePresent);
                    //onePresent.Top = AllChristmasspresent.Count * onePresent.Height;
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("There is no data in the textboxes");
            }
        }
    }    
}

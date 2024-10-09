using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatgyak
{
    public partial class Form1 : Form
    {
        dbHandler db = new dbHandler();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            read();
            addB.Click += addBClick;
            delB.Click += delBClick;
            delAllB.Click += delAllBClick;
        }
        void addBClick(object s, EventArgs e)
        {
            wasd one = new wasd();
            one.prop1 = Convert.ToInt32(prop1T.Text);
            one.prop2 = prop2T.Text;
            db.Insert(one);
            read();
        }
        void delBClick(object s, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                List<wasd> list = db.Read();
                db.Delete(list[listBox1.SelectedIndex].id);
                read();
            }
        }
        void delAllBClick(object s, EventArgs e)
        {
            db.deleteAll();
            read();
        }
        void read()
        {
            List<wasd> list = db.Read();
            listBox1.Items.Clear();
            foreach (wasd item in list)
            {
                listBox1.Items.Add($"{item.id}, {item.prop1}, {item.prop2}");
            }
        }
    }
}

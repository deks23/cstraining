using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ZabawkiDoDodania.Items.Add(new Car());

        }

        private void SpeedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DecreaseButton_Click(object sender, EventArgs e)
        {

        }

        private void IncreaseButton_Click(object sender, EventArgs e)
        {

        }

      

        private void ZabawkiDoDodania_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Object selectedItem = ZabawkiDoDodania.SelectedItem;
           if(selectedItem is Car)
            {
                DodaneZabawki.Items.Add(new Car());
            }
        }

        private void DodaneZabawki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

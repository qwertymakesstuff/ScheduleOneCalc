using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule_1_Calculator
{
    public partial class Form1 : Form
    {
        int price, total, drugprice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cbxDrugs.Items.Add("");
            cbxDrugs.Items.Add("OG Kush Seeds");
            cbxDrugs.Items.Add("Sour Diesel Seeds");
            cbxDrugs.Items.Add("Green Crack Seeds");
            cbxDrugs.Items.Add("Granddaddy Purple Seeds");
            cbxDrugs.Items.Add("Low-Quality Pseudo");
            cbxDrugs.Items.Add("Pseudo");
            cbxDrugs.Items.Add("High-Quality Pseudo");
            cbxDrugs.Items.Add("Coca Seeds");
            cbxItems.Items.Add("");
            cbxItems.Items.Add("Grow tent");
            cbxItems.Items.Add("Soil");
            cbxItems.Items.Add("Long-Lasting Soil");
            cbxItems.Items.Add("Extra Long-Lasting Soil");
            cbxItems.Items.Add("Watering Can");
            cbxItems.Items.Add("Plant Trimmers");
            cbxItems.Items.Add("Electric Plant Trimmers");
            cbxItems.Items.Add("Packaging Station");
            cbxItems.Items.Add("Packaging Station MK 2");
            cbxItems.Items.Add("Baggie");
            cbxItems.Items.Add("Bed");
            cbxItems.Items.Add("Coffee Table");
            cbxItems.Items.Add("Wooden Table");
            cbxItems.Items.Add("Metal Table");
            cbxItems.Items.Add("Lamp");
            cbxItems.Items.Add("TV");
            cbxItems.Items.Add("Small Storage Shelf");
            cbxItems.Items.Add("Medium Storage Shelf");
            cbxItems.Items.Add("Large Storage Shelf");
            cbxItems.Items.Add("Display Cabinet");
            cbxItems.Items.Add("Trash Bag");
            cbxItems.Items.Add("Trash Grabber");
            cbxItems.Items.Add("Trash Can");
            cbxItems.Items.Add("Jar");
            cbxItems.Items.Add("Fertilizer");
            cbxItems.Items.Add("PGR");
            cbxItems.Items.Add("Pot Sprinkler");
            cbxItems.Items.Add("Mixing Station");
            cbxItems.Items.Add("Soil Pourer");
            cbxItems.Items.Add("Cheap Skateboard");
            cbxItems.Items.Add("Skateboard");
            cbxItems.Items.Add("Lightweight Skateboard");
            cbxItems.Items.Add("Cuke");
            cbxItems.Items.Add("Banana");
            cbxItems.Items.Add("Paracetamol");
            cbxItems.Items.Add("Donut");
            cbxItems.Items.Add("Viagra");
            cbxItems.Items.Add("Mouth wash");
            cbxItems.Items.Add("Flu Medicine");
            cbxItems.Items.Add("Gasoline");
            cbxItems.Items.Add("Energy Drink");
            cbxItems.Items.Add("Motor Oil");
            cbxItems.Items.Add("Mega Bean");
            cbxItems.Items.Add("Chili");
            cbxItems.Items.Add("Battery");
            cbxItems.Items.Add("Iodine");
            cbxItems.Items.Add("Addy");
            cbxItems.Items.Add("Horse Semen");
            cbxItems.Items.Add("Acid");
            cbxItems.Items.Add("Phosphorus");
            cbxItems.Items.Add("Plastic Pot");
            cbxItems.Items.Add("Moisture Preserving Pot");
            cbxItems.Items.Add("Suspension Rack");
            cbxItems.Items.Add("Halogen Grow Light");
            cbxItems.Items.Add("LED Grow Light");
            cbxItems.Items.Add("Full Spectrum Grow Light");
            cbxItems.Items.Add("Chemistry Station");
            cbxItems.Items.Add("Lab Oven");
            cbxItems.Items.Add("Mixing Station MK 2");
            cbxItems.Items.Add("Air Pot");
            cbxItems.Items.Add("Drying Rack");
            cbxItems.Items.Add("Brick Press");
            cbxItems.Items.Add("Cauldron");
            cbxItems.SelectedIndex = 0;
            cbxDrugs.SelectedIndex = 0;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
 

        private void calculate()
        {
            int[] prices = new int[]
            {
                0,
                100,
                10,
                30,
                60,
                15,
                10,
                50,
                100,
                750,
                1,
                150,
                120,
                50,
                60,
                25,
                300,
                30,
                45,
                60,
                250,
                1,
                20,
                25,
                3,
                30,
                30,
                30,
                200,
                500,
                300,
                75,
                250,
                500,
                2,
                2,
                3,
                3,
                4,
                4,
                5,
                5,
                6,
                6,
                7,
                7,
                8,
                8,
                9,
                9,
                40,
                40,
                20,
                50,
                40,
                40,
                80,
                200,
                100,
                1000,
                2000,
                120,
                250,
                800,
                3000
            };
            int[] drugprices = new int[]
            {
                0,
                30,
                35,
                40,
                45,
                60,
                80,
                110,
                150
            };

            if (cbxItems.SelectedIndex != 0)
            {
                price = prices[cbxItems.SelectedIndex] * Convert.ToInt16(txtItems.Text);
                lstItems.Items.Add(cbxItems.SelectedItem + " x" + txtItems.Text + " - " + price.ToString("C"));
            }

            if (cbxDrugs.SelectedIndex != 0)
            {
                drugprice = drugprices[cbxDrugs.SelectedIndex] * Convert.ToInt16(txtDrugs.Text);
                lstItems.Items.Add(cbxDrugs.SelectedItem + " x" + txtDrugs.Text + " - " + drugprice.ToString("C"));
            }
            total += price;
            total += drugprice;
            lblCost.Text = "Total: "+total.ToString("C");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calculate();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lblCost.Text = "Total: ";
            txtDrugs.Text = "";
            txtItems.Text = "";
            price = 0;
            total = 0;
            drugprice = 0;
            cbxDrugs.SelectedIndex = 0;
            cbxItems.SelectedIndex = 0;
            cbxItems.Focus();
        }

    }
}

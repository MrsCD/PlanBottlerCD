using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanBottler1
{
    public partial class Form1 : Form
    {



       private Drink[] drinks = new Drink[10];


        private Beer weizen;
        private Beer heineken;
        private Beer wasseralfinger;
        private Wine redWine;
        private Wine whiteWine;
        private Liquor ramazotti;
        private Liquor campari;
        private Liquor jackDaniels;
        private Soda coke;
        private Soda fanta;
        private Soda sprite;
        private Juice apple;
        private Juice orange;
        private Juice tomato;
        private Water withGas;
        private Water withoutGas;
        private Coffee coffee;
        private Coffee cappuccino;
        private Coffee machhiatto;
        private Tea camille;
        private Tea ginger;
        private Tea peppermint;
        private Hot_Chocolate hotChoco;



        public Form1()
        {
            InitializeComponent();
            weizen = new Beer("Weizen", 5, 2.50);
            heineken = new Beer("Heineken", 5, 3.00);
            wasseralfinger = new Beer("Wasseralfinger", 6, 2.20);

            

            redWine = new Wine("Red Wine", 5, 4.50);
            whiteWine = new Wine("White Wine", 6, 4.50);

            ramazotti = new Liquor("Ramazotti", 6, 3.20);
            campari = new Liquor("Campari", 6, 3.20);
            jackDaniels = new Liquor("Jack Daniels", 7, 3.60);

            coke = new Soda("Coke", 7, 1.80);
            fanta = new Soda("Fanta", 8, 1.80);
            sprite = new Soda("Sprite", 7, 1.80);

            apple = new Juice("Apple", 7, 1.50);
            orange = new Juice("Orange", 8, 1.50);
            tomato = new Juice("Tomato", 7, 1.50);

            withGas = new Water("w/Gas", 7, 1.00);
            withoutGas = new Water("w/out Gas", 7, 1.00);

            coffee = new Coffee("Coffee", 7, 1.50);
            cappuccino = new Coffee("Cappuccino", 7, 1.5);
            machhiatto = new Coffee("Machhiatto", 7, 1.50);

            camille = new Tea("Camille", 7, 1.00);
            ginger = new Tea("Ginger", 7, 1.00);
            peppermint = new Tea("Peppermint", 7, 1.00);

            hotChoco = new Hot_Chocolate("Hot Choco", 7, 1.70);
            drinks[0] = wasseralfinger;
            drinks[1] = weizen;
            drinks[2] = heineken;
            drinks[3] = heineken;
            drinks[4] = heineken;
            drinks[5] = peppermint;
                
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    cbSubType.Items.Clear();
                    cbSubType.Items.Add("Juice");
                    cbSubType.Items.Add("Water");
                    cbSubType.Items.Add("Soda");
                    break;

                case 1:
                    cbSubType.Items.Clear();
                    cbSubType.Items.Add("Beer");
                    cbSubType.Items.Add("Wine");
                    cbSubType.Items.Add("Liquor");
                    break;

                case 2:
                    cbSubType.Items.Clear();
                    cbSubType.Items.Add("Coffee");
                    cbSubType.Items.Add("Tea");
                    cbSubType.Items.Add("Hot Choco");
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Non Alcoholic Drinks");
            comboBox1.Items.Add("Alcoholic Drinks");
            comboBox1.Items.Add("Hot Drinks");
        }

        private void cbSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSubType.SelectedItem.ToString())
            {
                case "Beer":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(weizen.name);
                    cbDrinks.Items.Add(heineken.name);
                    cbDrinks.Items.Add(wasseralfinger.name);
                    break;

                case "Wine":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(redWine.name);
                    cbDrinks.Items.Add(whiteWine.name);
                    break;

                case "Liquor":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(ramazotti.name);
                    cbDrinks.Items.Add(campari.name);
                    cbDrinks.Items.Add(jackDaniels.name);
                    break;

                case "Soda":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(coke.name);
                    cbDrinks.Items.Add(fanta.name);
                    cbDrinks.Items.Add(sprite.name);
                    break;

                case "Water":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(withGas.name);
                    cbDrinks.Items.Add(withoutGas.name);
                    break;

                case "Coffee":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(coffee.name);
                    cbDrinks.Items.Add(cappuccino.name);
                    cbDrinks.Items.Add(machhiatto.name);
                    break;

                case "Tea":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(camille.name);
                    cbDrinks.Items.Add(ginger.name);
                    cbDrinks.Items.Add(peppermint.name);
                    break;

                case "Juice":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(apple.name);
                    cbDrinks.Items.Add(tomato.name);
                    cbDrinks.Items.Add(orange.name);
                    break;

                case "Hot Choco":
                    cbDrinks.Items.Clear();
                    cbDrinks.Items.Add(hotChoco.name);
                    break;

            }
        }

        private void cbDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = double.NaN;

            //Beer
            switch (cbDrinks.SelectedItem.ToString())
            {
                case "Weizen":
                    price = weizen.price;
                    break;

                case "Heineken":
                    price = heineken.price;
                    break;

                case "Wasseralfinger":
                    price = wasseralfinger.price;
                    break;

                case "Red Wine":
                    price = redWine.price;
                    break;

                case "White Wine":
                    price = whiteWine.price;
                    break;

                case "Ramazotti":
                    price = ramazotti.price;
                    break;

                case "Campari":
                    price = campari.price;
                    break;

                case "Jack Daniels":
                    price = jackDaniels.price;
                    break;

                case "Coke":
                    price = coke.price;
                    break;

                case "Fanta":
                    price = fanta.price;
                    break;

                case "Sprite":
                    price = sprite.price;
                    break;

                case "Apple":
                    price = apple.price;
                    break;

                case "Orange":
                    price = orange.price;
                    break;

                case "Tomato":
                    price = tomato.price;
                    break;

                case "w/Gas":
                    price = withGas.price;
                    break;

                case "w/out Gas":
                    price = withoutGas.price;
                    break;

                case "Coffee":
                    price = coffee.price;
                    break;

                case "Machhiatto":
                    price = machhiatto.price;
                    break;

                case "Cappuccino":
                    price = cappuccino.price;
                    break;

                case "Camille":
                    price = camille.price; ;
                    break;

                case "Peppermint":
                    price = peppermint.price;
                    break;

                case "Ginger":
                    price = ginger.price;
                    break;

                case "Hot Choco":
                    price = hotChoco.price;
                    break;

               case "":
                    tbPrice.Text = price.ToString();
                    break;

            }

            tbPrice.Text = price.ToString("C", CultureInfo.CurrentUICulture);
            string name = cbDrinks.SelectedItem.ToString();
            Drink first = drinks[0];
            int drinkCount = 0;

            cbAvail.Items.Clear();
            for (int i=0; i<drinks.Length; i++)
            {
                if (drinks[i]!=null && drinks[i].name==cbDrinks.SelectedItem.ToString())
                {
                    drinkCount++;
                    cbAvail.Items.Add(drinkCount);
                }

                //Console.WriteLine(drinks);
            }

            int[] liste = new int[] { 1, 2, 3 };
            for (int i=0; i<liste.Length; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }
    
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAvail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void euroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("de-DE");
        }

        private void dollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
        }

        private void ok_Click(object sender, EventArgs e)
        {


        } 

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

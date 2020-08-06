using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace broker
{
    public partial class broker : Form
    {
        public broker()
        {
            InitializeComponent();
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
        Object[,] assetsInStock = new Object[11, 5];
        Object[,] assetsInWallet = new Object[11, 6];                   // Quantity added, 
        public void broker_Load(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet("andre.marra", 3072.356m);
            //AssetsInStock B3SA3 = new AssetsInStock("B3SA3", "B3 SA - Brasil Bolsa Balcao", 63.51m, "BRL", 0.44f);
            //AssetsInStock BPAC11 = new AssetsInStock("BPAC11", "Banco BTG Pactual SA Brazilian Units", 88.20m, "BRL", 1.15f);
            var teste = (Object) 5f;
            assetsInStock = new Object[,] {   { "B3SA3", "B3 SA - Brasil Bolsa Balcao", 63.51m, "BRL", 0.44f },
                { "BPAC11", "Banco BTG Pactual SA Brazilian Units", 88.20m, "BRL", 1.15f },
                { "ITSA4", "Itausa Investimentos Itau SA Preference Shares", 10.21m, "BRL", 0.098f },
                { "PETR4", "Petroleo Brasileiro SA Petrobras Preference Shares", 23.30m, "BRL", 0.52f },
                { "EMBR3", "Embraer", 7.56m, "BRL", -1.31f },
                { "ABEV3", "AMBEV", 13.18m, "BRL", 0.098f },
                { "CIEL3", "Cielo", 5.43m, "BRL", 7.31f },
                { "MGLU3", "Magazine Luiza", 84.82m, "BRL", 2.16f },
                { "AZUL4", "Azul", 2.95m, "BRL", 3.92f },
                { "GOLL4", "Gol", 18.20m, "BRL", 3.23f },
                { "ELET3", "Eletrobras", 38.51m, "BRL", 4.93f } };
            for (int i = 0; i < assetsInStock.GetLength(0); i++)
            {
                listViewAssetsInStock.Items.Add(new ListViewItem(new string[] { assetsInStock[i, 0].ToString(), assetsInStock[i, 4].ToString() + "%", assetsInStock[i, 2].ToString() + assetsInStock[i, 3], assetsInStock[i, 1].ToString() }));
            }

            //listViewAssetsInWallet.Items.Add(new ListViewItem(new string[] { B3SA3.cod, B3SA3.varDay.ToString()+"%", B3SA3.unitPrice.ToString()+B3SA3.currency}));
            //listViewAssetsInStock.Items.Add(new ListViewItem(new string[] { B3SA3.cod, B3SA3.varDay.ToString() + "%", B3SA3.unitPrice.ToString() + B3SA3.currency }));
            setlistViewAssetsInWallet();
            timer1.Start();
            labelUsername.Text = wallet.username;                                                                   //
            string userBalance = wallet.userBalance.ToString();                                                     //
            userBalance = userBalance.Substring(0, userBalance.IndexOf(",")+3);                                     // Transforma Decimal em String com 2 digitos após a virgula
            labelUserBalance.Text = userBalance;

        }
        private void setlistViewAssetsInWallet()
        {
            listViewAssetsInWallet.View = View.Details;
            
            listViewAssetsInWallet.Columns.Add("Ativo");
            listViewAssetsInWallet.Columns.Add("Qnt");                                                              // Novo
            listViewAssetsInWallet.Columns.Add("Var");
            listViewAssetsInWallet.Columns.Add("Último");
            listViewAssetsInWallet.Columns.Add("Total");                                                            // Novo
            listViewAssetsInWallet.Columns.Add("Nome");

            listViewAssetsInStock.View = View.Details;
            
            listViewAssetsInStock.Columns.Add("Ativo");
            listViewAssetsInStock.Columns.Add("Var");
            listViewAssetsInStock.Columns.Add("Último");
            listViewAssetsInStock.Columns.Add("Nome");

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string stockSelectedItem;
            int i;
            if (txbBuyQuantity.Text == "") { return; }
            int quantityBuy = Int32.Parse(txbBuyQuantity.Text);
            try
            {
            stockSelectedItem = listViewAssetsInStock.SelectedItems[0].Text;                            // Get selected item in stock listview
            }
            catch{return;}

            for (i = 0; i < 11; i++)                                                                    // Search selected item in array to find index i
            {
                if(assetsInStock[i, 0].ToString() == stockSelectedItem) { break; }
            }

            for (int j = 0; j < 11; j++)                                                                
            {
                if(i==j && assetsInWallet[j, 0] == null)
                {
                    assetsInWallet[i, 0] = assetsInStock[i, 0]; // cod
                    assetsInWallet[i, 1] = assetsInStock[i, 1]; // name
                    assetsInWallet[i, 2] = assetsInStock[i, 2]; // last
                    assetsInWallet[i, 3] = assetsInStock[i, 3]; // currency
                    assetsInWallet[i, 4] = assetsInStock[i, 4]; // var
                    assetsInWallet[i, 5] = (object) quantityBuy; // var
                    ListViewItem newItem = new ListViewItem(new string[] { assetsInStock[i, 0].ToString(), assetsInWallet[i, 5].ToString(), assetsInStock[i, 4].ToString() + "%", assetsInStock[i, 2].ToString() + assetsInStock[i, 3], assetsInStock[i, 1].ToString() });
                    listViewAssetsInWallet.Items.Add(newItem);
                    return;
                }
                else if (i == j)
                {
                    listViewAssetsInWallet.Items.Remove(listViewAssetsInWallet.Items.Find(stockSelectedItem, false)[0]);
                    assetsInWallet[i, 5] = (object) (Int32.Parse(assetsInWallet[i, 5].ToString())+quantityBuy);          // Quantity
                    ListViewItem newItem = new ListViewItem(new string[] { assetsInStock[i, 0].ToString(), assetsInWallet[i, 5].ToString(), assetsInStock[i, 4].ToString() + "%", assetsInStock[i, 2].ToString() + assetsInStock[i, 3], assetsInStock[i, 1].ToString() });
                    listViewAssetsInWallet.Items.Add(newItem);

                }

            }
            
        }

        private void listViewAssetsInStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        Object[,] assetsInWallet = new Object[11, 6];                   // Quantity added, 
        //List<AssetsInStock> assetsInStock = new List<AssetsInStock>();

        public void broker_Load(object sender, EventArgs e)
        {
            Wallet wallet = new Wallet("andre.marra", 3072.356m);
            var assetsInStock = new List<AssetsInStock>() {
                new AssetsInStock(){cod = "B3SA3", name = "B3 SA - Brasil Bolsa Balcao", lastPrice = 63.51m, currency = "BRL", varDay = 0.44f},
                new AssetsInStock(){cod = "BPAC11", name = "Banco BTG Pactual SA Brazilian Units", lastPrice = 88.20m, currency = "BRL", varDay = 1.15f},
                new AssetsInStock(){cod = "ITSA4", name = "Itausa Investimentos Itau SA Preference Shares", lastPrice = 10.21m, currency = "BRL", varDay = 0.098f},
                new AssetsInStock(){cod = "PETR4", name = "Petroleo Brasileiro SA Petrobras Preference Shares", lastPrice = 23.30m, currency = "BRL", varDay = 0.52f},
                new AssetsInStock(){cod = "EMBR3", name = "Embraer", lastPrice = 7.56m, currency = "BRL", varDay = -1.31f},
                new AssetsInStock(){cod = "ABEV3", name = "AMBEV", lastPrice = 13.18m, currency = "BRL", varDay = 0.098f},
                new AssetsInStock(){cod = "CIEL3", name = "Cielo", lastPrice = 5.43m, currency = "BRL", varDay = 7.31f},
                new AssetsInStock(){cod = "MGLU3", name = "Magazine Luiza", lastPrice = 84.82m, currency = "BRL", varDay = 2.16f},
                new AssetsInStock(){cod = "AZUL4", name = "Azul", lastPrice = 2.95m, currency = "BRL", varDay = 3.92f},
                new AssetsInStock(){cod = "GOLL4", name = "Gol", lastPrice = 18.20m, currency = "BRL", varDay = 3.23f},
                new AssetsInStock(){cod = "ELET3", name = "Eletrobras", lastPrice = 38.51m, currency = "BRL", varDay = 4.93f}
            };

            for (int i = 0; i < assetsInStock.Count; i++)
            {
                listViewAssetsInStock.Items.Add(new ListViewItem(new string[] { assetsInStock[i].cod, assetsInStock[i].varDay + "%", assetsInStock[i].lastPrice.ToString("0.##"), assetsInStock[i].name }));
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

            var teste1 = assetsInStock;
            for (i = 0; i < 11; i++)                                                                    // Search selected item in array to find index i
            {
                if (assetsInStockNew[i].cod == stockSelectedItem) { break; }
            }

            for (int j = 0; j < 11; j++)
            {
                if (i == j && assetsInWallet[j, 0] == null)
                {
                    assetsInWallet[i, 0] = assetsInStockNew[i].cod; // cod
                    assetsInWallet[i, 1] = assetsInStockNew[i].name; // name
                    assetsInWallet[i, 2] = assetsInStockNew[i].lastPrice; // last
                    assetsInWallet[i, 3] = assetsInStockNew[i].currency; // currency
                    assetsInWallet[i, 4] = assetsInStockNew[i].varDay; // var
                    assetsInWallet[i, 5] = (object)quantityBuy; // var
                    ListViewItem newItem = new ListViewItem(new string[] { assetsInStock[i, 0].ToString(), assetsInWallet[i, 5].ToString(), assetsInStock[i, 4].ToString() + "%", assetsInStock[i, 2].ToString() + assetsInStock[i, 3], assetsInStock[i, 1].ToString() });
                    listViewAssetsInWallet.Items.Add(newItem);
                    return;
                }
                else if (i == j)
                {
                    listViewAssetsInWallet.Items.Remove(listViewAssetsInWallet.Items.Find(stockSelectedItem, false)[0]);
                    assetsInWallet[i, 5] = (object)(Int32.Parse(assetsInWallet[i, 5].ToString()) + quantityBuy);          // Quantity
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

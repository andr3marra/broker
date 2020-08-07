using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        string stockListSelectedItem;
        int quantityBuy;
        AssetsInStock selectedAssetsInStock;

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            labelUserBalance.Text = wallet.userBalance.ToString("0.##");
            if (txbBuyQuantity.Text != "") { quantityBuy = Int32.Parse(txbBuyQuantity.Text); }

            

            try
            {
                stockListSelectedItem = listViewAssetsInStock.SelectedItems[0].Text;                            // Get selected item in stock listview
                selectedAssetsInStock = assetsInStock.Find(assetsInStock => assetsInStock.cod == stockListSelectedItem);
                labelAmount.Text = (selectedAssetsInStock.lastPrice * quantityBuy).ToString();
            }
            catch { return; }
        }

        //Object[,] assetsInWallet = new Object[11, 6];                   // Quantity added, 
        List<AssetsInStock> assetsInStock = new List<AssetsInStock>();
        List<AssetsInWallet> assetsInWallet = new List<AssetsInWallet>();
        Wallet wallet = new Wallet();

        public void broker_Load(object sender, EventArgs e)
        {
            wallet.username = "andre.marra";
            wallet.userBalance = 3072.356m;
            
            // Assets in stock
            assetsInStock.Add(new AssetsInStock() { cod = "B3SA3", name = "B3 SA - Brasil Bolsa Balcao", lastPrice = 63.51m, currency = "BRL", varDay = 0.44f });
            assetsInStock.Add(new AssetsInStock() { cod = "BPAC11", name = "Banco BTG Pactual SA Brazilian Units", lastPrice = 88.20m, currency = "BRL", varDay = 1.15f });
            assetsInStock.Add(new AssetsInStock() { cod = "ITSA4", name = "Itausa Investimentos Itau SA Preference Shares", lastPrice = 10.21m, currency = "BRL", varDay = 0.098f });
            assetsInStock.Add(new AssetsInStock() { cod = "PETR4", name = "Petroleo Brasileiro SA Petrobras Preference Shares", lastPrice = 23.30m, currency = "BRL", varDay = 0.52f });
            assetsInStock.Add(new AssetsInStock() { cod = "EMBR3", name = "Embraer", lastPrice = 7.56m, currency = "BRL", varDay = -1.31f });
            assetsInStock.Add(new AssetsInStock() { cod = "ABEV3", name = "AMBEV", lastPrice = 13.18m, currency = "BRL", varDay = 0.098f });
            assetsInStock.Add(new AssetsInStock() { cod = "CIEL3", name = "Cielo", lastPrice = 5.43m, currency = "BRL", varDay = 7.31f });
            assetsInStock.Add(new AssetsInStock() { cod = "AZUL4", name = "Azul", lastPrice = 2.95m, currency = "BRL", varDay = 3.92f });
            assetsInStock.Add(new AssetsInStock() { cod = "GOLL4", name = "Gol", lastPrice = 18.20m, currency = "BRL", varDay = 3.23f });
            assetsInStock.Add(new AssetsInStock() { cod = "ELET3", name = "Eletrobras", lastPrice = 38.51m, currency = "BRL", varDay = 4.93f });
            for (int i = 0; i < assetsInStock.Count; i++)
            {
                listViewAssetsInStock.Items.Add(new ListViewItem(new string[] { assetsInStock[i].cod, assetsInStock[i].varDay + "%", assetsInStock[i].lastPrice.ToString("0.##"), assetsInStock[i].name }));
            }
            setlistViewAssetsInWallet();
            timer1.Start();
            labelUsername.Text = wallet.username;                                                                   //
            

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
            if (txbBuyQuantity.Text == "" || txbBuyQuantity.Text == "0") { return; }
            try
            {
            stockListSelectedItem = listViewAssetsInStock.SelectedItems[0].Text;                            // Get selected item in stock listview
            }
            catch{return;}

            selectedAssetsInStock = assetsInStock.Find(assetsInStock => assetsInStock.cod == stockListSelectedItem);
            var selectedAssetsInWallet = assetsInWallet.Find(assetsInWallet => assetsInWallet.cod == stockListSelectedItem);

            if(wallet.userBalance >= selectedAssetsInStock.lastPrice * quantityBuy)
            {
                wallet.userBalance -= selectedAssetsInStock.lastPrice * quantityBuy;
            }
            else
            {
                return;
            }

            if (selectedAssetsInWallet == null)
            {
                assetsInWallet.Add(new AssetsInWallet() { cod = selectedAssetsInStock.cod, name = selectedAssetsInStock.name, lastPrice = selectedAssetsInStock.lastPrice, currency = selectedAssetsInStock.currency, varDay = selectedAssetsInStock.varDay, quantity = quantityBuy });
                int countAssetsInWallet = assetsInWallet.Count;
                ListViewItem newItem = new ListViewItem(new string[] { assetsInWallet[countAssetsInWallet-1].cod, assetsInWallet[countAssetsInWallet - 1].quantity.ToString(), assetsInWallet[countAssetsInWallet - 1].varDay.ToString() + "%", assetsInWallet[countAssetsInWallet - 1].lastPrice.ToString() + assetsInWallet[countAssetsInWallet - 1].currency, (assetsInWallet[countAssetsInWallet - 1].lastPrice* assetsInWallet[countAssetsInWallet - 1].quantity).ToString(), assetsInWallet[countAssetsInWallet - 1].name });
                listViewAssetsInWallet.Items.Add(newItem);
                return;
            }
            else
            {
                selectedAssetsInWallet.quantity += quantityBuy;                                                     // Update quantity in assetsInWallet
                var selectedItemInListView = listViewAssetsInWallet.FindItemWithText(stockListSelectedItem);        // Get ListView asset object in Wallet
                selectedItemInListView.SubItems[1].Text = selectedAssetsInWallet.quantity.ToString();               // Update quantity in listViewWallet
                selectedItemInListView.SubItems[4].Text = (selectedAssetsInWallet.lastPrice * selectedAssetsInWallet.quantity).ToString();

            }
        }

        private void listViewAssetsInStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

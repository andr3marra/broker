using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace broker
{
    public class AssetsInStock
    {
        public string cod;
        public string name;
        public decimal lastPrice;
        public string currency;
        public float varDay;
        public AssetsInStock()
        {

        }
        public static async Task getAssetData()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.hgbrasil.com/finance/stock_price?key=4331e1b1&symbol=b3sa3");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(responseBody);
                var teset = json.results["B3SA3"].name;

                Console.WriteLine(teset);
                Console.WriteLine("Oi");

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

        }
        /*        public AssetsInStock(string cod, string name, decimal unitPrice, string currency, float varDay)
                {
                    this.cod = cod;
                    this.name = name;
                    this.unitPrice = unitPrice;
                    this.currency = currency;
                    this.varDay = varDay;
                }*/



    }

    class AssetsInWallet : AssetsInStock
    {
        public int quantity;
        public float varSinceBuy;
        public DateTime buyDate;
        public decimal assetBalance;
        public float var;
/*        public AssetsInWallet(decimal assetBalance)
        {
            this.assetBalance = assetBalance;

        }*/
    }
    class Wallet
    {
        public string username;
/*        public string Username
        {
            get { return username; }
            set { username = value; }
        }*/
        public decimal userBalance;
        public float varSinceBuy;
/*        public Wallet(string username, decimal userBalance)
        {
            this.username = username;
            this.userBalance = userBalance;
        }*/
        bool verifyBalance()
        {
            return true;
        }
        void changeBalance(decimal totalPrice)
        {
            this.userBalance = -totalPrice;
        }

    }
    class BackEnd
    {


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broker
{
    class AssetsInStock
    {
        public string cod;
        public string name;
        public decimal lastPrice;
        public string currency;
        public float varDay;
/*        public AssetsInStock(string cod, string name, decimal unitPrice, string currency, float varDay)
        {
            this.cod = cod;
            this.name = name;
            this.unitPrice = unitPrice;
            this.currency = currency;
            this.varDay = varDay;
        }*/

    }

    class AssetsInWallet
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
        public Wallet(string username, decimal userBalance)
        {
            this.username = username;
            this.userBalance = userBalance;
        }
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

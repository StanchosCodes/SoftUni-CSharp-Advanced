using System;
using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count
        {
            get
            {
                return this.Portfolio.Count;
            }
        }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            this.FullName = fullName;
            this.EmailAddress = emailAddress;
            this.MoneyToInvest = moneyToInvest;
            this.BrokerName = brokerName;
            this.Portfolio = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization >= 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                this.Portfolio.Add(stock);
                this.MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            //Stock currStock = this.Portfolio.Find(s => s.CompanyName == companyName);
            //if (currStock.CompanyName != companyName)
            //{
            //    return $"{companyName} does not exist.";
            //}

            //if (sellPrice < currStock.PricePerShare)
            //{
            //    return $"Cannot sell {companyName}";
            //}

            //this.Portfolio.Remove(currStock);
            //this.MoneyToInvest += sellPrice;
            //return $"{companyName} was sold.";

            foreach (Stock stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    if (sellPrice < stock.PricePerShare)
                    {
                        return $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        this.Portfolio.Remove(stock);
                        MoneyToInvest += sellPrice;
                        return $"{companyName} was sold.";

                    }
                }
            }

            return $"{companyName} does not exist.";
        }

        public Stock FindStock(string companyName)
        {
            foreach (var stock in this.Portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }

            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (this.Portfolio.Count == 0)
            {
                return null;
            }

            decimal biggestCapitalization = decimal.MinValue;
            Stock maxStock = null;

            foreach (var stock in this.Portfolio)
            {
                if (stock.MarketCapitalization > biggestCapitalization)
                {
                    biggestCapitalization = stock.MarketCapitalization;
                    maxStock = stock;
                }
            }

            // return Portfolio.Find(s => s.MarketCapitalization == biggestCapitalization);
            return maxStock;
        }

        public string InvestorInformation()
        {
            return $"The investor {this.FullName} with a broker {this.BrokerName} has stocks:{Environment.NewLine}" +
                $"{string.Join($"{Environment.NewLine}", this.Portfolio)}";
        }
    }
}
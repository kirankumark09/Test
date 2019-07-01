using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Stock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Stock" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Stock.svc or Stock.svc.cs at the Solution Explorer and start debugging.
    public class Stocks : IStock
    {
        #region IStock Members
        public Stock GetStock(string Symbol)
        {
            Stock st = null;
            switch (Symbol.ToUpper())
            {
                case "GOOG":
                    st = new Stock
                    {
                        Symbol = Symbol,
                        Date = DateTime.Now,
                        Company = "Google Inc.",
                        Close = 495
                    };
                    break;
                case "MSFT":
                    st = new Stock
                    {
                        Symbol = Symbol,
                        Date = DateTime.Now,
                        Company = "Microsoft Corporation",
                        Close = 25
                    };
                    break;
                case "YHOO":
                    st = new Stock
                    {
                        Symbol = Symbol,
                        Date = DateTime.Now,
                        Company = "Yahoo! Inc.",
                        Close = 17
                    };
                    break;
                case "AMZN":
                    st = new Stock
                    {
                        Symbol = Symbol,
                        Date = DateTime.Now,
                        Company = "Amazon.com, Inc.",
                        Close = 92
                    };
                    break;
            }
            return st;
        }
        #endregion
    }
}

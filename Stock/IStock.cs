using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Stock
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStock" in both code and config file together.
    [ServiceContract]
    public interface IStock
    {
        [OperationContract]
        Stock GetStock(string Symbol);
    }

    [DataContract]
    public class Stock
    {
        [DataMember]
        public string Symbol { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public decimal Close { get; set; }
    }
}

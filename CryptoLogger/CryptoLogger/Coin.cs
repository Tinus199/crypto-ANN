using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLogger
{
    class Coin
    {
        public DateTime Last_Updated { get; set; }
        public int Rank { get; set; }
        public double Price_Usd { get; set; }
        public double Price_Btc { get; set; }
        public double Volume_24H { get; set; }
        public double Marketcao_Usd { get; set; }
        public double Available_Supply { get; set; }
        public double Total_Supply { get; set; }
        public double Max_Supply { get; set; }
        public double Change_1H { get; set; }
        public double Change_24H { get; set; }
        public double Change_7d { get; set; }
    }
}

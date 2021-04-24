using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Models
{
    public class InMemoryStockDb : IInMemoryStockDb
    {
        public static List<DailyStockDetails> dailyStockDetails = new List<DailyStockDetails> {
            new DailyStockDetails { StockId=1,StockName="ABC",StockValue=100},
            new DailyStockDetails { StockId = 2, StockName = "DEF", StockValue = 200 },
            new DailyStockDetails { StockId = 3, StockName = "GHI", StockValue = 300 },
            new DailyStockDetails { StockId = 4, StockName = "JKL", StockValue = 400 },
            new DailyStockDetails { StockId = 5, StockName = "MNO", StockValue = 500 }
            };

        public DailyStockDetails DailySharePrice(string stockName)
        {
            return dailyStockDetails.FirstOrDefault(c=>c.StockName.ToLower()==stockName.ToLower());
        }

       
    }
}

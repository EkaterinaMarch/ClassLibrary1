using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockSharp.Quik;
using StockSharp.BusinessEntities;
using StockSharp.Community;
using StockSharp.Algo;
using Ecng.ComponentModel;
using StockSharp.Algo.Candles;
using StockSharp.Messages;
namespace ClassLibrary1
{
    public class Class1
    {
        
        QuikTrader quiktrader;
        
        CandleManager candlemanager = new CandleManager();
     //   CandleSeries candleseries = new CandleSeries();
         public  void Connect()
         {// quiktrader.DdeTables = new [] {quiktrader.SecuritiesTable}
           var terminal = QuikTerminal.Get(@"C:\BCS_Work\Учебный QUIK БКС");
            if (!terminal.IsLaunched)
            {
                 quiktrader = new QuikTrader(QuikTerminal.GetDefaultPath()) { Path = QuikTerminal.GetDefaultPath() };                 
                 

                
                    Console.WriteLine("Запускается Quik...");                    
                 

            //candleseries = new CandleSeries();
            //candlemanager.Start(candleseries);

        }
        public void Buy (int volume, string company)
        {   
            Order order = new Order();
            //      order.Trader
            order.Direction = Sides.Buy;
            order.Volume = volume;
         //   order.Security = new Security { f}
           // order.
            //quiktrader.RegisterOrder(order);
        }

        public void Sell ()
        {

        }
        public void Disconnect ()
        {   
             
        }

        private void Quiktrader_Connected()
        {
            
        }
    }
}

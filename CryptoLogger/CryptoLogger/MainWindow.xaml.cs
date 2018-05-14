using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace CryptoLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            const string uri = @"https://api.coinmarketcap.com/v1/ticker/?limit=5000";
            var client = new WebClient();
            var content = client.DownloadString(uri);

            var currencies = JsonConvert
                .DeserializeObject<List<Coinmarketcap_ticker>>(content);


            foreach (Coinmarketcap_ticker ticker in currencies)
            {
                Console.WriteLine(ticker.id);
            }
        }


        //setup the database by scanning coinmarketcap for new coins. If a coin is found that
        //is not listed in the database create a table for the coin.
        //
        public bool scan_create_coins()
        {


            return false;
        }
    }
}

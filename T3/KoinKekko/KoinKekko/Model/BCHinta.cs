using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KoinKekko.Model
{
    public class BCHinta
    {
        private List<Tuple<DateTime, double>> bcHinta;
        private List<Tuple<DateTime, double>> bcVoluumi;

        public event Action<List<Tuple<DateTime, double>>, List<Tuple<DateTime, double>>> OnDataFetched;

        public async Task BitcoinDataFetchAsync(DateTime startDate, DateTime endDate)
        {
            long from = UnixTimestampToDateTime(startDate);
            long to = UnixTimestampToDateTime(endDate);

            string apiUrl = $"https://api.coingecko.com/api/v3/coins/bitcoin/market_chart/range?vs_currency=eur&from={from}&to={to}";

            try
            {
                using HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(apiUrl);
                var parsedData = JsonConvert.DeserializeObject<BCData>(response);
                ProcessMarketData(parsedData);
            }
            catch (Exception)
            {
                MessageBox.Show("Dont do that!");
            }
        }

        private void ProcessMarketData(BCData data)
        {
            bcHinta = new List<Tuple<DateTime, double>>();
            bcVoluumi = new List<Tuple<DateTime, double>>();

            foreach (var price in data.prices)
            {
                var time = DateTimeToUnix(price[0]);
                bcHinta.Add(new Tuple<DateTime, double>(time, price[1]));
            }

            foreach (var volume in data.total_volumes)
            {
                var time = DateTimeToUnix(volume[0]);
                bcVoluumi.Add(new Tuple<DateTime, double>(time, volume[1]));
            }

            OnDataFetched?.Invoke(bcHinta, bcVoluumi);
        }

        public static long UnixTimestampToDateTime(DateTime dt)
        {
            var epochStart = new DateTime(1970, 1, 1);
            var utcTime = TimeZoneInfo.ConvertTimeToUtc(dt);
            return (long)(utcTime - epochStart).TotalSeconds;
        }

        public static DateTime DateTimeToUnix(double unixMilliseconds)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds((long)unixMilliseconds).UtcDateTime;
        }
    }
}

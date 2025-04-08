using KoinKekko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoinKekko.Controller
{
    public class BCLogiikka : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private readonly BCHinta BcHinta;

        public event Action<List<Tuple<DateTime, double>>> OnPriceDataUpdated;

        public BCLogiikka()
        {
            BcHinta = new BCHinta();
            BcHinta.OnDataFetched += OnBitcoinDataFetch;
        }

        public async Task BitcoinDataFetchAsync(DateTime StartDate, DateTime EndDate)
        {
            if (StartDate != null && EndDate != null)
            {
                await BcHinta.BitcoinDataFetchAsync(StartDate, EndDate);
            }
        }

        public void OnBitcoinDataFetch(List<Tuple<DateTime, double>> bcHinta, List<Tuple<DateTime, double>> bcVoluumi)
        {
            OnPriceDataUpdated?.Invoke(bcHinta);

            var minPriceData = bcHinta.MinBy(x => x.Item2);
            var maxPriceData = bcHinta.MaxBy(x => x.Item2);
            MinPrice = minPriceData?.Item2;
            MaxPrice = maxPriceData?.Item2;

            var minVolumeData = bcVoluumi.MinBy(x => x.Item2);
            var maxVolumeData = bcVoluumi.MaxBy(x => x.Item2);
            MinVolume = minVolumeData?.Item2;
            MaxVolume = maxVolumeData?.Item2;

            var bullish = CalculateTrendLenght(bcHinta, true);
            var bearish = CalculateTrendLenght(bcHinta, false);

            BullishStart = bullish.start?.ToString("dd/MM/yyyy hh:mm");
            BullishEnd = bullish.end?.ToString("dd/MM/yyyy hh:mm");
            BearishStart = bearish.start?.ToString("dd/MM/yyyy hh:mm");
            BearishEnd = bearish.end?.ToString("dd/MM/yyyy hh:mm");

            var bestTrade = FindBestBuySellDays(bcHinta);
            BestBuyDate = bestTrade.Item1?.ToString("dd/MM/yyyy hh:mm");
            BestSellDate = bestTrade.Item2?.ToString("dd/MM/yyyy hh:mm");
        }

        private (int length, DateTime? start, DateTime? end) CalculateTrendLenght(List<Tuple<DateTime, double>> bcHinta, bool isBullish)
        {
            if (bcHinta == null || bcHinta.Count < 2) return (0, null, null);

            int longest = 0, current = 0;
            DateTime? currStart = null, longestStart = null, longestEnd = null;

            for (int i = 1; i < bcHinta.Count; i++)
            {
                if ((isBullish && bcHinta[i].Item2 > bcHinta[i - 1].Item2) || (!isBullish && bcHinta[i].Item2 < bcHinta[i - 1].Item2))
                {
                    current++;
                    currStart ??= bcHinta[i - 1].Item1;
                }
                else
                {
                    if (current > longest)
                    {
                        longest = current;
                        longestStart = currStart;
                        longestEnd = bcHinta[i - 1].Item1;
                    }
                    current = 0;
                    currStart = null;
                }
            }

            if (current > longest)
            {
                longest = current;
                longestStart = currStart;
                longestEnd = bcHinta[^1].Item1;
            }

            return (longest, longestStart, longestEnd);
        }

        private Tuple<DateTime?, DateTime?> FindBestBuySellDays(List<Tuple<DateTime, double>> bcHinta)
        {
            if (bcHinta == null || bcHinta.Count < 2) return Tuple.Create<DateTime?, DateTime?>(null, null);

            double minPrice = double.MaxValue, maxProfit = 0;
            DateTime? buyDate = null, sellDate = null;

            foreach (var data in bcHinta)
            {
                if (data.Item2 < minPrice)
                {
                    minPrice = data.Item2;
                    buyDate = data.Item1;
                }

                double profit = data.Item2 - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    sellDate = data.Item1;
                }
            }

            return Tuple.Create(buyDate, sellDate);
        }

        private double? minVolume;
        public double? MinVolume
        {
            get => minVolume;
            set
            {
                minVolume = value;
                OnPropertyChanged(nameof(MinVolume));
            }
        }

        private double? maxVolume;
        public double? MaxVolume
        {
            get => maxVolume;
            set
            {
                maxVolume = value;
                OnPropertyChanged(nameof(MaxVolume));
            }
        }

        private double? minPrice;
        public double? MinPrice
        {
            get => minPrice;
            set
            {
                minPrice = value;
                OnPropertyChanged(nameof(MinPrice));
            }
        }

        private double? maxPrice;
        public double? MaxPrice
        {
            get => maxPrice;
            set
            {
                maxPrice = value;
                OnPropertyChanged(nameof(MaxPrice));
            }
        }

        private string? bullishStart;
        public string? BullishStart
        {
            get => bullishStart;
            set
            {
                bullishStart = value;
                OnPropertyChanged(nameof(BullishStart));
            }
        }

        private string? bullishEnd;
        public string? BullishEnd
        {
            get => bullishEnd;
            set
            {
                bullishEnd = value;
                OnPropertyChanged(nameof(BullishEnd));
            }
        }

        private string? bearishStart;
        public string? BearishStart
        {
            get => bearishStart;
            set
            {
                bearishStart = value;
                OnPropertyChanged(nameof(BearishStart));
            }
        }

        private string? bearishEnd;
        public string? BearishEnd
        {
            get => bearishEnd;
            set
            {
                bearishEnd = value;
                OnPropertyChanged(nameof(BearishEnd));
            }
        }

        private string? bestBuyDate;
        public string? BestBuyDate
        {
            get => bestBuyDate;
            set
            {
                bestBuyDate = value;
                OnPropertyChanged(nameof(BestBuyDate));
            }
        }

        private string? bestSellDate;
        public string? BestSellDate
        {
            get => bestSellDate;
            set
            {
                bestSellDate = value;
                OnPropertyChanged(nameof(BestSellDate));
            }
        }
    }
}

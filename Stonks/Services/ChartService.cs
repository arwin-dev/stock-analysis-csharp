using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using Stonks.Models;
using System.Collections.Generic;
using System.Linq;

namespace Stonks.Services
{
    public class ChartService : ObservableObject
    {
        public Axis[] XAxes { get; set; }

        public ISeries[] Series { get; set; }
        public ChartService(List<aCandlestick> candlestickList)
        {
            Series = new ISeries[]
            {
                new CandlesticksSeries<FinancialPointI>
                {
                    Values = candlestickList.Select(x => new FinancialPointI( (double) x.high, (double) x.open, (double) x.close, (double) x.low))
                    .ToArray()
                }
            };

            XAxes = new[]
            {
                new Axis
                {
                    LabelsRotation = 15,
                    Labels = candlestickList.Select(x => x.date.ToString("yyyy MMM dd"))
                    .ToArray()
                }
            };
        }

    }
}

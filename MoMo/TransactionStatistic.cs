using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using MoMo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting.Effects;

namespace MoMo
{
    public partial class TransactionStatistic : Form
    {
        DateTime monthToFilter;

        public TransactionStatistic()
        {
            InitializeComponent();
        }

        public TransactionStatistic(string MonthYear)
        {
            InitializeComponent();
            this.monthToFilter = DateTime.ParseExact(MonthYear, "MM/yyyy", null);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            StackNavigation.Pop();
        }

        private void CreateStatisticForAMonthChart()
        {
            // Get all transaction in this month
            // group by week
            // split by income and expense
            // sum up
            // display

            // Get all transaction in this month
            List<Transaction> transactions;

            using (UserDbContext db = new UserDbContext())
            {
                transactions = db.Transactions
                    .Where(t =>
                        (t.Date.Month == monthToFilter.Month && t.Date.Year == monthToFilter.Year)
                        && (t.SenderId == Session.LoggedInUserInfo!.Id || t.ReceiverId == Session.LoggedInUserInfo!.Id))
                    .ToList();
            }

            // calculate total income and expense
            var income = transactions
                .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id)
                .Sum(t => t.Amount)
                .ToString();

            var outcome = transactions
                .Where(t => t.ReceiverId == Session.LoggedInUserInfo!.Id)
                .Sum(t => t.Amount)
                .ToString();

            var averageWeekIncome = Utils.VNCurrencyToDouble(income) / 4;


            label4.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(income));
            label7.Text = Utils.FormatVNCurrency(averageWeekIncome);

            // convert datetime to month/year string
            label3.Text = "Tháng " + monthToFilter.Month.ToString() + "/" + monthToFilter.Year.ToString();

            label9.Text = Utils.FormatVNCurrency(Utils.VNCurrencyToDouble(outcome) - Utils.VNCurrencyToDouble(income));

            // Income group by week
            var incomeGroupByWeek = transactions
                .Where(t => t.ReceiverId == Session.LoggedInUserInfo!.Id)
                .GroupBy(t => t.Date.Day / 7)
                .Select(g => new
                {
                    Week = g.Key,
                    Sum = g.Sum(t => t.Amount),
                    Count = g.Count()
                })
                .ToList();

            // Expense group by week
            var outcomeGroupByWeek = transactions
                .Where(t => t.SenderId == Session.LoggedInUserInfo!.Id)
                .GroupBy(t => t.Date.Day / 7)
                .Select(g => new
                {
                    Week = g.Key,
                    Sum = g.Sum(t => t.Amount),
                    Count = g.Count()
                })
                .ToList();

            // Using LiveChart to display data
            CartesianChart cartesianChart = new();

            cartesianChart.Series = new ISeries[]
            {
                new ColumnSeries<CustomChartPoint>
                {
                    Values = (from temp
                             in incomeGroupByWeek
                                select new CustomChartPoint
                                {
                                    Name = $"Tuần thứ {temp.Week}",
                                    Value = temp.Sum,
                                    Count = temp.Count,
                                }).ToList(),
                    Name = "Lượng tiền nhận vào",
                    TooltipLabelFormatter = (chartpoint) =>
                        $"{Utils.FormatVNCurrency(chartpoint.PrimaryValue)} - {chartpoint.TertiaryValue} giao dịch",
                    Mapping = (group, point) =>
                    {
                        point.PrimaryValue = group.Value;
                        point.SecondaryValue = point.Context.Entity.EntityIndex;
                        point.TertiaryValue = group.Count;
                    }
                },
                new ColumnSeries<CustomChartPoint>
                {
                    Values = (from temp
                             in outcomeGroupByWeek
                                select new CustomChartPoint
                                {
                                    Name = $"Tuần thứ {temp.Week}",
                                    Value = temp.Sum,
                                    Count = temp.Count,
                                }).ToList(),
                    Name = "Lượng tiền sử dụng",
                    TooltipLabelFormatter = (chartpoint) =>
                        $"{Utils.FormatVNCurrency(chartpoint.PrimaryValue)} - {chartpoint.TertiaryValue} giao dịch",
                    Mapping = (group, point) =>
                    {
                        point.PrimaryValue = group.Value;
                        point.SecondaryValue = point.Context.Entity.EntityIndex;
                        point.TertiaryValue = group.Count;
                    }
                }
            };

            List<string> labels = new List<string>();

            if (incomeGroupByWeek.Any())
                labels = incomeGroupByWeek.Select(temp => $"Tuần thứ {temp.Week}").ToList();
            else if (outcomeGroupByWeek.Any())
                labels = outcomeGroupByWeek.Select(temp => $"Tuần thứ {temp.Week}").ToList();


            cartesianChart.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = labels,
                    TextSize = 12,
                    NamePadding = new LiveChartsCore.Drawing.Padding(20),
                }
            };

            cartesianChart.YAxes = new Axis[]
            {
                new Axis
                {
                   Labeler = (value) => Utils.FormatVNCurrency(value, isShorten:true),
                   TextSize = 12,
                   ShowSeparatorLines = true,
                   SeparatorsPaint = new SolidColorPaint{
                       Color = new SKColor(160, 160, 160),
                       StrokeThickness = 1,
                       PathEffect = new DashEffect(new float[] { 3, 3 })
                   },
                }
            };

            cartesianChart.LegendPosition = LegendPosition.Top;
            cartesianChart.ZoomMode = ZoomAndPanMode.X;
            cartesianChart.BackColor = Color.White;

            cartesianChart.Dock = DockStyle.Fill;
            panel2.Controls.Add(cartesianChart);
        }

        private void TransactionStatistic_Load(object sender, EventArgs e)
        {
            CreateStatisticForAMonthChart();
        }
    }
}

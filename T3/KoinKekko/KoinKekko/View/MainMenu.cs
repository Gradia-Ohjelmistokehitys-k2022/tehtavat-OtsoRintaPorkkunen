using KoinKekko.Controller;

namespace KoinKekko
{
    public partial class MainMenu : Form
    {
        private BCLogiikka bclogiikka;

        public MainMenu()
        {
            InitializeComponent();
            InitializeLogic();
            InitializeBindings();
            InitializeGrid();
            SetDefaultDates();
        }

        private void InitializeLogic()
        {
            bclogiikka = new BCLogiikka();
            bclogiikka.OnPriceDataUpdated += UpdateDataGridView;
        }

        private void InitializeBindings()
        {
            label1.DataBindings.Add(new Binding("Text", bclogiikka, "MaxPrice", true, DataSourceUpdateMode.OnPropertyChanged));
            label2.DataBindings.Add(new Binding("Text", bclogiikka, "MinPrice", true, DataSourceUpdateMode.OnPropertyChanged));

            label3.DataBindings.Add(new Binding("Text", bclogiikka, "MaxVolume", true, DataSourceUpdateMode.OnPropertyChanged));
            label4.DataBindings.Add(new Binding("Text", bclogiikka, "MinVolume", true, DataSourceUpdateMode.OnPropertyChanged));

            label5.DataBindings.Add(new Binding("Text", bclogiikka, "BullishStart", true, DataSourceUpdateMode.OnPropertyChanged));
            label6.DataBindings.Add(new Binding("Text", bclogiikka, "BullishEnd", true, DataSourceUpdateMode.OnPropertyChanged));

            label7.DataBindings.Add(new Binding("Text", bclogiikka, "BearishStart", true, DataSourceUpdateMode.OnPropertyChanged));
            label8.DataBindings.Add(new Binding("Text", bclogiikka, "BearishEnd", true, DataSourceUpdateMode.OnPropertyChanged));

            label9.DataBindings.Add(new Binding("Text", bclogiikka, "BestBuyDate", true, DataSourceUpdateMode.OnPropertyChanged));
            label10.DataBindings.Add(new Binding("Text", bclogiikka, "BestSellDate", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void InitializeGrid()
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Price", "Price");
        }

        private void SetDefaultDates()
        {
            dateTimePicker1.Value = DateTime.Today.AddDays(-1);
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bclogiikka.BitcoinDataFetchAsync(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void UpdateDataGridView(List<Tuple<DateTime, double>> prices)
        {
            Invoke(new Action(() =>
            {
                dataGridView1.Rows.Clear();
                foreach (var priceEntry in prices)
                {
                    dataGridView1.Rows.Add(priceEntry.Item1.ToString("dd/MM/yyyy HH:mm"), priceEntry.Item2);
                }
            }));
        }
    }
}

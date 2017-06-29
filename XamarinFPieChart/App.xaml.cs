using CrossPieCharts.FormsPlugin.Abstractions;
using Xamarin.Forms;
//using Xamarin.Plugin.CrossPieChart;

namespace XamarinFPieChart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CrossPieChartSample().GetPageWithPieChart();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

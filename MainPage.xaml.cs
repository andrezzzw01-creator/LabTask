namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        // Change from 'void' to 'async void'
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // 1. Create an instance of the target page
            var secondPage = new Lab2task();

            // 2. Navigate to the new page using PushAsync
            await Navigation.PushAsync(secondPage);

            // You can optionally keep the counter logic if you want:
            // count++;
            // if (count == 1)
            //     CounterBtn.Text = $"Clicked {count} time";
            // else
            //     CounterBtn.Text = $"Clicked {count} times";
            // SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}


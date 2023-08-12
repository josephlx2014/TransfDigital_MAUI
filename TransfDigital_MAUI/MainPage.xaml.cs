namespace TransfDigital_MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();



        }

        void OnHorizontalStartClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Start; }
        void OnHorizontalCenterClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Center; }
        void OnHorizontalEndClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.End; }
        void OnHorizontalFillClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Fill; }

        void OnVerticalStartClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Start; }
        void OnVerticalCenterClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Center; }
        void OnVerticalEndClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.End; }
        void OnVerticalFillClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Fill; }
    }
}
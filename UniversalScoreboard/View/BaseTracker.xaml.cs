namespace UniversalScoreboard.View;

public partial class BaseTracker : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(BaseTracker), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(BaseTracker.CardTitleProperty);
        set => SetValue(BaseTracker.CardTitleProperty, value);
    }
    public BaseTracker()
	{
		InitializeComponent();
	}
}
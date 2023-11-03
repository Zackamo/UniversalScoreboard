namespace UniversalScoreboard.View;

public partial class TrackerMenuCardView : ContentView
{

    public TrackerMenuCardView(TrackerMenuCardViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = viewModel;
	}
}
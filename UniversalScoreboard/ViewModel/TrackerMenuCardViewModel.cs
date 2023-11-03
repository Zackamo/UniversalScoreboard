
namespace UniversalScoreboard.ViewModel;

public partial class TrackerMenuCardViewModel : ObservableObject
{
    [ObservableProperty]
    string trackerName = "Default Name";

    public TrackerMenuCardViewModel()
	{
		
	}
    public void OnButtonClicked() 
    {
        trackerName = "clicked";
    }

}
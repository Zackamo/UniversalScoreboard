using System.Security.Cryptography.X509Certificates;

namespace UniversalScoreboard.ViewModel;

public partial class BaseTrackerViewModel : ObservableObject
{
    [ObservableProperty]
    string trackerName = "Default Name";

    public BaseTrackerViewModel()
	{
		
	}
}
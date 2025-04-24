using CommunityToolkit.Mvvm.ComponentModel;
using MVVMSample.ViewModel;

namespace MVVMSample.Model
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        TrainViewModel _train;
    }
}

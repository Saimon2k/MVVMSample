using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using MVVMSample.Model;

namespace MVVMSample.ViewModel
{
    public partial class TrainViewModel : ObservableObject
    {
        private readonly Train _train;
        private readonly ILogger<TrainViewModel>? _logger;

        //[ObservableProperty]
        //private UserViewModel _user;

        public TrainViewModel(Train train, ILogger<TrainViewModel>? logger = null)
        {
            _logger = logger!;

            _logger?.LogTrace("TrainViewModel.ctor");
            _train = train;
            //_user = new() { Train = this };
        }

        public int Progress
        {
            get => _train.Progress;
            set => SetProperty(_train.Progress, value, _train, (u, n) => u.Progress = n);
        }

        public bool Left
        {
            get => _train.Left;
            set => SetProperty(_train.Left, value, _train, (u, n) => u.Left = n);
        }

        public bool Right
        {
            get => _train.Right;
            set => SetProperty(_train.Right, value, _train, (u, n) => u.Right = n);
        }

        [RelayCommand]
        private void OnProgress()
        {
            _train.OnProgress();
            OnPropertyChanged(nameof(Progress));
        }
    }
}

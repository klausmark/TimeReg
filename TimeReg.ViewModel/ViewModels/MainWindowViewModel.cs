using System.Collections.ObjectModel;
using TimeReg.Model;
using TimeReg.Model.Repositories;
using TimeReg.ViewModel.BaseClasses;

namespace TimeReg.ViewModel.ViewModels
{
    public class MainWindowViewModel : NotifyBase
    {
        public MainWindowViewModel()
        {
            Times = new ObservableCollection<Time>(TimeRepository.GetAll());
        }

        private ITimeRepository TimeRepository { get; set; } = new TimeMemoryRepository();

        public ObservableCollection<Time> Times { get; }
    }
}

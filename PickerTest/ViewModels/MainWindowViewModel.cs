using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace PickerTest.ViewModels
{
    public partial class MainWindowViewModel: ObservableObject
    {

        [ObservableProperty]
        public List<string> names =
        [
           "Alexander",
            "Luis",
            "Miguel",
            "Javier",
            "Carlos",
            "Juan",
            "Pedro",
            "Jose",
            "Ricardo",
            "Fernando",
            "Jorge",
            "Alberto",
        ];
    }
}

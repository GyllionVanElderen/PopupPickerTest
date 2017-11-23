using PopupPickerTest.Views;
using Prism.Commands;
using Prism.Navigation;
using Rg.Plugins.Popup.Contracts;

namespace PopupPickerTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand OpenPopupCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService, IPopupNavigation popupNavigation) 
            : base (navigationService, popupNavigation)
        {
            Title = "Main Page";

            OpenPopupCommand = new DelegateCommand(OpenPopup);
        }

        private void OpenPopup()
        {
            PopupWithPickerPageViewModel viewModel =
                new PopupWithPickerPageViewModel(NavigationService, PopupNavigation);

            PopupNavigation.PushAsync(new PopupWithPickerPage { BindingContext =  viewModel });
        }
    }
}

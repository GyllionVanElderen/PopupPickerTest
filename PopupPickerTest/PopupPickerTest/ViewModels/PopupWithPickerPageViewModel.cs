using System.Collections.Generic;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Contracts;

namespace PopupPickerTest.ViewModels
{
    public class PopupWithPickerPageViewModel : ViewModelBase
	{
	    public List<string> ItemList { get; set; }
        public DelegateCommand ClosePopupCommand { get; set; }

        public PopupWithPickerPageViewModel(INavigationService navigationService, IPopupNavigation popupNavigation) 
            : base(navigationService, popupNavigation)
        {
            ItemList = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
            };

            ClosePopupCommand = new DelegateCommand(ClosePopup);
        }

	    private void ClosePopup()
	    {
	        NavigationService.GoBackAsync();
	    }
	}
}

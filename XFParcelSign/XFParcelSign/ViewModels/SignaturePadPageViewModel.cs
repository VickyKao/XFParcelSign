using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SignaturePad.Forms;
using XFParcelSign.Views;

namespace XFParcelSign.ViewModels
{

    public class SignaturePadPageViewModel : INotifyPropertyChanged, INavigationAware {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        public DelegateCommand SubmitCommand { get; set; }



        public SignaturePadPageViewModel(INavigationService navigationService) {
            _navigationService = navigationService;

            SubmitCommand = new DelegateCommand(async () => {
                //var signedImageStream = await signPad.GetImageStreamAsync(SignatureImageFormat.Png);
                //if (signedImageStream != null) {
                //}
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters) {

        }

        public void OnNavigatingTo(NavigationParameters parameters) {

        }

        public void OnNavigatedTo(NavigationParameters parameters) {

        }

    }

}

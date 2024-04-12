using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Identity.Client;

namespace WH2.ViewModel
{
    public partial class EingabeViewModel : ObservableObject
    {   
        [ObservableProperty]
        string eingabe_UI_User;
        [ObservableProperty]
        string eingabe_UI_Password;
        [RelayCommand]
        public void Login()
        {
            string Eingabe_UI_User = eingabe_UI_User;
            string Eingabe_UI_Password= eingabe_UI_Password;
            bool isAccessSucces; 
            SQL AnmeldeEingaben = new SQL(Eingabe_UI_User, Eingabe_UI_Password);
            isAccessSucces = AnmeldeEingaben.Login(AnmeldeEingaben.connection);
            if (isAccessSucces)
            {
                Shell.Current.GoToAsync(nameof(Eingabe));

            }
            else
            {
               eingabe_UI_User= RückGabeBeiFalscherAnmeldung();

            }
        }
        public static string RückGabeBeiFalscherAnmeldung()
        {
            string RGW = "Melde dich richtig an du Wurst.";
            return RGW;
        }


    }
}

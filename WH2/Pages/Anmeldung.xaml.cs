//using FileProvider;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using CommunityToolkit.Mvvm;
using WH2.ViewModel;
using WH2;

namespace WH2
{
    public partial class Anmeldung : ContentPage
    {
       
        public Anmeldung(EingabeViewModel VM)
        {

            InitializeComponent(); 
            BindingContext = VM;
        }

        
        
    }
}

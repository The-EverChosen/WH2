namespace WH2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Eingabe),typeof(Eingabe));
            Routing.RegisterRoute(nameof(Ausgabe),typeof(Ausgabe));
        }
    }
}

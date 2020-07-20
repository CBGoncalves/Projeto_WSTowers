using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class PrincipalView : TabbedPage
    {

        public IList<Jogo> Jogos { get; private set; }
        public PrincipalView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            Jogos = new List<Jogo>();
            Jogos.Add(new Jogo
            {
                idJogo = 1,
                timeCasa = "São Paulo",
                timeVisitante = "Goias",
                data = Convert.ToDateTime("09/08/2020"),
            });

            Jogos.Add(new Jogo
            {
                idJogo = 2,
                timeCasa = "Flamengo",
                timeVisitante = "Atlético-MG",
                data = Convert.ToDateTime("07/07/2020"),
               

            });

            BindingContext = this;
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetalhesView { });
        }
    }
}
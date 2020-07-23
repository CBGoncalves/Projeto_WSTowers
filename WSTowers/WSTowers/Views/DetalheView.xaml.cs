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
    public partial class DetalhesView : ContentPage
    {
        public IList<Elenco> Jogadores { get; set; }
        public DetalhesView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);

            Jogadores = new List<Elenco>();
            Jogadores.Add(new Elenco
            {
                IdJogador = 1,
                Nome= "Alexandre Pato",
                Numero = 7,
                Posicao = "Atacante",
                Time = "São Paulo"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 2,
                Nome = "Tiago Volpi",
                Numero = 1,
                Posicao = "Goleiro",
                Time = "São Paulo"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 3,
                Nome = "Daniel Alves",
                Numero = 10,
                Posicao = "Meia",
                Time = "São Paulo"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 4,
                Nome = "Tchê Tchê",
                Numero = 8,
                Posicao = "Volante",
                Time = "São Paulo"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 5,
                Nome = "Yago Rocha",
                Numero = 5,
                Posicao = "Volante",
                Time = "Goias"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 6,
                Nome = "Marcelo Rangel",
                Numero = 1,
                Posicao = "Goleiro",
                Time = "Goias"
            });

            Jogadores.Add(new Elenco
            {
                IdJogador = 7,
                Nome = "Breno",
                Numero = 7,
                Posicao = "Meia",
                Time = "Goias"
            });

            BindingContext = this;
        }
    }
}
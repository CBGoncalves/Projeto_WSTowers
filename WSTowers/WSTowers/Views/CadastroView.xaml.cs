using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;
using WSTowers.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroView : ContentPage
    {
        private static IList<Usuario> Usuarios;
        public CadastroView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }

        private async void BtnCadastro_Clicked(object sender, EventArgs e)
        {
            if(Usuarios == null)
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe seu nome", "OK");
                    return;
                }

                if (string.IsNullOrEmpty(txtApelido.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe o apelido", "OK");
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe o email", "OK");
                    return;
                }

                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    await DisplayAlert("ATENÇÃO", "Informe a senha", "OK");
                    return;
                }

                Usuario usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Apelido = txtApelido.Text,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    
                };

                await DisplayAlert("SUCESSO", "Usuário cadastrado com sucesso.", "OK");



            }
        }
    }
}
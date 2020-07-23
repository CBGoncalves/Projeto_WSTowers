using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;
using WSTowers.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        UsuarioRepository usuariosRepository = new UsuarioRepository();
        public LoginView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            {
                
                Usuario usuario = usuariosRepository.Login(txtEmail.Text, txtSenha.Text);

                if (usuario != null && usuario.Email == txtEmail.Text && usuario.Senha == txtSenha.Text)
                {

                    Navigation.InsertPageBefore(new PrincipalView(), this) ;
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Erro", "Dados não congruentes", "Ok");
                    txtSenha.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                }
            }
            
        }

        private void btnCadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroView());
        }
    }
}
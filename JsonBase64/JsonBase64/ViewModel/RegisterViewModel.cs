using JsonBase64.Model;
using JsonBase64.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JsonBase64.ViewModel
{
    public class RegisterViewModel : BaseViewModel<Usuario>
    {
        private Command _registerCommand;
        private string _jsonResult;
        private UsuariosService usuariosService;

        public RegisterViewModel(Usuario model = null) : base(model)
        {
            if(model == null)
            {
                Model = new Usuario();
            }

            usuariosService = new UsuariosService();
        }

        public string Username
        {
            get => Model.Username;

            set
            {
                if (string.Equals(value, Model.Username)) return;
                Model.Username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => Model.Password;

            set
            {
                if (string.Equals(value, Model.Password)) return;
                Model.Password = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get => Model.Nombre;

            set
            {
                if (string.Equals(value, Model.Nombre)) return;
                Model.Nombre = value;
                OnPropertyChanged();
            }
        }

        public string Ap1
        {
            get => Model.Ap1;

            set
            {
                if (string.Equals(value, Model.Ap1)) return;
                Model.Ap1 = value;
                OnPropertyChanged();
            }
        }

        public string Ap2
        {
            get => Model.Ap2;

            set
            {
                if (string.Equals(value, Model.Ap2)) return;
                Model.Ap2 = value;
                OnPropertyChanged();
            }
        }

        public string JsonResult
        {
            get => _jsonResult;

            set
            {
                if (string.Equals(value, _jsonResult)) return;
                _jsonResult = value;
                OnPropertyChanged();
            }

        }

        public Command RegisterCommand
        {
            get => _registerCommand ?? ( _registerCommand = new Command( RegisterAction ));
        }

        private async void RegisterAction()
        {
            Usuario newObject = EncryptOrDecryptData(true);
            JsonResult = await usuariosService?.Register(newObject);
        }
    }
}

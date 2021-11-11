using JsonBase64.Model;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JsonBase64.ViewModel
{
    public class FotoViewModel : BaseViewModel<Foto>
    {
        private Command _capturarCommand;
        public FotoViewModel(Foto model = null) : base(model)
        {
            
            if (model == null)
            {
                Model = new Foto();
            }

            // TODO fotoService = new FotoService();
        }

        public ImageSource Img
        {
            get => Model.Img;

            set
            {
                if (value == Model.Img) return;
                Model.Img = value;
                OnPropertyChanged();
            }
        }

        public Command CapturarCommand
        {
            get => _capturarCommand ?? (_capturarCommand = new Command(TomarFoto));
        }
    

        private async void TomarFoto()
        {
            var camara = new StoreCameraMediaOptions();
            camara.PhotoSize = PhotoSize.Full;
            camara.SaveToAlbum = true;
            var foto = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(camara);
            if (foto != null)
            {
                Img = ImageSource.FromStream(() =>
                {
                    return foto.GetStream();
                });
            }
        }

    }
}

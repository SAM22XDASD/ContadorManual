using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ContadorManual.Model
{
    class Contador : INotifyPropertyChanged
    {
        private int _Conteo;

        public event PropertyChangingEventHandler PropertyChanged;
        public int Conteo
        {
            get => _Conteo;
            set
            {
                if (_Conteo != value)
                {
                    _Conteo = value;
                    OnPropertyChanged("Conteo");
                }
            }
        }
        public Contador()
        {
            ReiniciarConteo();
        }
        public void Contar()
        {
            Conteo++;
        }
        public void ReiniciarConteo()
        {
            Conteo = 0;
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }

}
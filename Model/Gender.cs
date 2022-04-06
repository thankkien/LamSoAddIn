using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LamSoAddIn.Model
{
    class Gender : INotifyPropertyChanged
    {
        private static readonly List<Gender> _list = new List<Gender>() { new Gender(true), new Gender(false) };
        private bool _isMale;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Gender()
        {
            IsMale = false;
        }

        public Gender(bool isMale)
        {
            IsMale = isMale;
        }

        [DisplayName("Là Nam?")]
        public bool IsMale
        {
            get { return _isMale; }
            set
            {
                if (_isMale != value)
                {
                    _isMale = value;
                    OnPropertyChanged("IsMale");
                    OnPropertyChanged("Sex");
                }
            }
        }

        [DisplayName("Giới tính")]
        public string Sex
        {
            get { return (this._isMale) ? "Nam" : "Nữ"; }
        }

        [Browsable(false)]
        public static List<Gender> List
        {
            get { return _list; }
        }

        public bool Equals(Gender g)
        {
            if (g is null) return false;
            if (this.GetType() != g.GetType()) return false;
            if (Object.ReferenceEquals(this, g)) return true;
            return (IsMale == g.IsMale);
        }

        public static bool operator ==(Gender lg, Gender rg)
        {
            if (lg is null)
            {
                if (rg is null) return true;
                return false;
            }
            return lg.Equals(rg);
        }

        public static bool operator !=(Gender lg, Gender rg) => !(lg == rg);
    }
}

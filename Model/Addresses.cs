using LamSoAddIn.Controller;
using System;
using System.ComponentModel;
using System.Globalization;

namespace LamSoAddIn.Model
{
    class Addresses : INotifyPropertyChanged
    {
        private string _id;
        private string _living;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Addresses()
        {
            ID = "DC-" + Property.GenerateID();
            Living = "";
        }

        public Addresses(string living)
        {
            ID = "DC-" + Property.GenerateID();
            Living = living;
        }

        public Addresses(string id, string living)
        {
            ID = id;
            Living = living;
        }

        [DisplayName("Mã Địa Chỉ")]
        public string ID
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        [DisplayName("Địa Chỉ")]
        public string Living
        {
            get { return _living; }
            set
            {
                if (value != null)
                {
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    value = textInfo.ToTitleCase(value.Trim());
                    if (value.Length > 500) _living = value.Substring(0, 499);
                    else if (_living != value)
                    {
                        _living = value;
                        OnPropertyChanged("Living");
                    }
                }
            }
        }

        public bool Equals(Addresses a)
        {
            if (a is null) return false;
            if (this.GetType() != a.GetType()) return false;
            if (Object.ReferenceEquals(this, a)) return true;
            return (ID == a.ID && Living == a.Living);
        }

        public static bool operator ==(Addresses la, Addresses ra)
        {
            if (la is null)
            {
                if (ra is null) return true;
                return false;
            }
            return la.Equals(ra);
        }

        public static bool operator !=(Addresses la, Addresses ra) => !(la == ra);
    }
}

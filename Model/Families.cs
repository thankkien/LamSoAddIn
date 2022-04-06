using LamSoAddIn.Controller;
using System;
using System.ComponentModel;
using System.Globalization;

namespace LamSoAddIn.Model
{
    class Families : INotifyPropertyChanged
    {
        private string _id;
        private string _familyName;
        private Addresses _address = new Addresses();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Families()
        {
            ID = "GD-" + Property.GenerateID();
            FamilyName = "";
            Address = new Addresses();
        }

        public Families(string familyName, Addresses address)
        {
            ID = "GD-" + Property.GenerateID();
            FamilyName = familyName;
            Address = address;
        }

        public Families(string id, string familyName, Addresses address)
        {
            ID = id;
            FamilyName = familyName;
            Address = address;
        }

        [DisplayName("Mã Hộ")]
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

        [DisplayName("Tên Hộ")]
        public string FamilyName
        {
            get { return _familyName; }
            set
            {
                if (value != null)
                {
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    value = textInfo.ToTitleCase(value.Trim());
                    if (value.Length > 50) _familyName = value.Substring(0, 49);
                    else if (_familyName != value)
                    {
                        _familyName = value;
                        OnPropertyChanged("FamilyName");
                    }
                }
            }
        }

        [Browsable(false)]
        public Addresses Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }

        [DisplayName("Mã địa chỉ")]
        public string AddressID
        {
            get { return Address.ID; }
            set
            {
                if (Address.ID != value)
                {
                    Address.ID = value;
                    OnPropertyChanged("AddressID");
                }
            }
        }

        [DisplayName("Địa chỉ")]
        public string Living
        {
            get { return Address.Living; }
            set
            {
                if (Address.Living != value)
                {
                    Address.Living = value;
                    OnPropertyChanged("Living");
                }
            }
        }

        public bool Equals(Families f)
        {
            if (f is null) return false;
            if (this.GetType() != f.GetType()) return false;
            if (Object.ReferenceEquals(this, f)) return true;
            return (ID == f.ID
                && FamilyName == f.FamilyName
                && Address == f.Address);
        }

        public static bool operator ==(Families lf, Families rf)
        {
            if (lf is null)
            {
                if (rf is null) return true;
                return false;
            }
            return lf.Equals(rf);
        }

        public static bool operator !=(Families lf, Families rf) => !(lf == rf);
    }
}

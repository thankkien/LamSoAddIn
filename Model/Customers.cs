using LamSoAddIn.Controller;
using System;
using System.ComponentModel;
using System.Globalization;

namespace LamSoAddIn.Model
{
    class Customers : INotifyPropertyChanged
    {
        private string _id;
        private string _fullname;
        private int _yearOfBirth;
        private Gender _gender = new Gender();
        private Families _family = new Families();

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Customers()
        {
            ID = "KH-" + Property.GenerateID();
            Fullname = "";
            YearOfBirth = DateTime.Now.Year;
            Gender = new Gender(true);
            Family = new Families();
        }

        public Customers(string fullname, int yearOfBirth, Gender gender, Families family)
        {
            ID = "KH-" + Property.GenerateID();
            Fullname = fullname;
            YearOfBirth = yearOfBirth;
            Gender = gender;
            Family = family;
        }

        public Customers(string id, string fullname, int yearOfBirth, Gender gender, Families family)
        {
            ID = id;
            Fullname = fullname;
            YearOfBirth = yearOfBirth;
            Gender = gender;
            Family = family;
        }

        [DisplayName("Mã số")]
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

        [DisplayName("Họ và tên")]
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (value != null)
                {
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    value = textInfo.ToTitleCase(value.Trim());
                    if (value.Length > 50) _fullname = value.Substring(0, 49);
                    else if (_fullname != value)
                    {
                        _fullname = value;
                        OnPropertyChanged("Fullname");
                    }
                }
            }
        }

        [DisplayName("Năm Sinh")]
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set
            {
                if (value < 0) _yearOfBirth = 0;
                else if (value > DateTime.Now.Year) _yearOfBirth = DateTime.Now.Year;
                else if (_yearOfBirth != value)
                {
                    _yearOfBirth = value;
                    OnPropertyChanged("YearOfBirth");
                }
            }
        }

        [Browsable(false)]
        public Gender Gender
        {
            get { return _gender; }
            set
            {
                if (_gender != value)
                {
                    _gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }

        [DisplayName("Là nam")]
        public bool IsMale
        {
            get { return Gender.IsMale; }
            set
            {
                if (Gender.IsMale != value)
                {
                    Gender.IsMale = value;
                    OnPropertyChanged("Gender");
                    OnPropertyChanged("Sex");
                }
            }
        }

        [DisplayName("Giới tính")]
        public string Sex
        {
            get { return Gender.Sex; }
        }

        [Browsable(false)]
        public Families Family
        {
            get { return _family; }
            set
            {
                if (_family != value)
                {
                    _family = value;
                    OnPropertyChanged("Family");
                }
            }
        }

        [DisplayName("Mã hộ")]
        public string FamilyID
        {
            get { return Family.ID; }
            set
            {
                if (Family.ID != value)
                {
                    Family.ID = value;
                    OnPropertyChanged("FamilyID");
                }
            }
        }

        [DisplayName("Hộ gia đình")]
        public string FamilyName
        {
            get { return Family.FamilyName; }
            set
            {
                if (Family.FamilyName != value)
                {
                    Family.FamilyName = value;
                    OnPropertyChanged("FamilyName");
                }
            }
        }

        [Browsable(false)]
        public Addresses Address
        {
            get { return Family.Address; }
            set
            {
                if (Family.Address != value)
                {
                    Family.Address = value;
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

        public bool Equals(Customers c)
        {
            if (c is null) return false;
            if (this.GetType() != c.GetType()) return false;
            if (Object.ReferenceEquals(this, c)) return true;
            return (ID == c.ID
                && Fullname == c.Fullname
                && YearOfBirth == c.YearOfBirth
                && Gender == c.Gender
                && Family == c.Family);
        }

        public static bool operator ==(Customers lc, Customers rc)
        {
            if (lc is null)
            {
                if (rc is null) return true;
                return false;
            }
            return lc.Equals(rc);
        }

        public static bool operator !=(Customers lc, Customers rc) => !(lc == rc);
    }
}

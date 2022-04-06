using Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace LamSoAddIn.Model
{
    class SheetItem : INotifyPropertyChanged
    {
        private bool _checked;
        private Worksheet _sheet;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SheetItem()
        {
            _checked = false;
            Sheet = new Worksheet();
        }

        public SheetItem(Worksheet sheet)
        {
            _checked = false;
            Sheet = sheet;
        }

        [DisplayName("Tên Trang")]
        public string Name { get { return Sheet.Name; } }

        [Browsable(false)]
        public Worksheet Sheet { get { return _sheet; } set { _sheet = value; OnPropertyChanged("Name"); OnPropertyChanged("Sheet"); } }

        [DisplayName("Chọn In")]
        public bool Checked { get { return _checked; } set { _checked = value; OnPropertyChanged("Checked"); } }
    }
}

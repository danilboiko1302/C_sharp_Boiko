using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
namespace BoikoLab01
{
 internal sealed class BdViewModel: INotifyPropertyChanged
    {
        
        private readonly BdModel _bdModel = new BdModel();
        private string _Age;
        private string _ChineseSign;

        private string _Sign;
        public BdViewModel()
        {
             _ChineseSign = "-";
             _Sign = "-";
             _Age = "-";
            OnPropertyChanged();
        }

        public string Age => $"Age: {_Age}";

        public string ChineseSign => $"Chinese Sign: {_ChineseSign}";

        public string Sign => $"Sign: {_Sign}";
        public DateTime BirthDate
        {
            get => _bdModel.BirthDate;

            set
            {
               
                if (_bdModel.BirthDate == value) return;
                _bdModel.BirthDate = value;
                _Age = _bdModel.Age;
                _ChineseSign = _bdModel.ChineseSign;
                _Sign = _bdModel.Sign;
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(ChineseSign));
                OnPropertyChanged(nameof(Sign));
                if (!_bdModel.IsCorrect)
                {
                    MessageBox.Show("Don`t funny al all");
                }
                else if (_bdModel.IsBirthday)
                {
                    MessageBox.Show("Happy BirthDAY!!!!!!!!!!!!!");
                }
            }
        }
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

       
    }
    
}
using System;
namespace BoikoLab01
{
  internal class BdModel
    {

        private static readonly string[] Signs = {"Aries","Taurus","Gemini","Cancer",
            "Leo","Virgo","Libra","Scorpio","Sagittarius","Capricorn","Aquarius","Pisces"
        };
        private static readonly string[] ChineseSigns = {"Rat","Ox","Tiger","Rabbit",
            "Dragon","Snake","Horse","Goat","Monkey","Rooster","Dog","Pig"
        };

       

        private DateTime _birthDate;
        internal bool IsCorrect { get; private set; }
        internal string Age { get; private set; }
        internal string Sign { get; private set; }
        internal string ChineseSign { get; private set; }

        internal BdModel()
        {
            _birthDate = DateTime.Today;
        }

        internal DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                
                _birthDate = value;
                var currentDate = DateTime.Today;
                var diffDateTime = currentDate - value;
                var years = (currentDate.Year - value.Year) - (currentDate.DayOfYear >= _birthDate.DayOfYear ? 0 : 1);
                if (diffDateTime.Days >= 0 && years <= 135)
                {
                    IsCorrect = true;
                    Age = "";
                    Age = years > 0 ? $"{years} years" : $"{diffDateTime.Days} years";
                   
                    ChineseSign = ChineseSigns[(_birthDate.Year + 8) % 12];
                    
                    var day = _birthDate.Day;
                    var numberWesternSign = -1;

                    switch (_birthDate.Month)
                    {
                        case 1: 
                            numberWesternSign = day <= 20 ? 9 : 10;
                            break;
                        case 2: 
                            numberWesternSign = day <= 19 ? 10 : 11;
                            break;
                        case 3: 
                            numberWesternSign = day <= 20 ? 11 : 0;
                            break;
                        case 4: 
                            numberWesternSign = day <= 20 ? 0 : 1;
                            break;
                        case 5: 
                            numberWesternSign = day <= 20 ? 1 : 2;
                            break;
                        case 6: 
                            numberWesternSign = day <= 20 ? 2 : 3;
                            break;
                        case 7: 
                            numberWesternSign = day <= 21 ? 3 : 4;
                            break;
                        case 8: 
                            numberWesternSign = day <= 22 ? 4 : 5;
                            break;
                        case 9: 
                            numberWesternSign = day <= 21 ? 5 : 6;
                            break;
                        case 10: 
                            numberWesternSign = day <= 21 ? 6 : 7;
                            break;
                        case 11: 
                            numberWesternSign = day <= 21 ? 7 : 8;
                            break;
                        case 12:
                            numberWesternSign = day <= 21 ? 8 : 9;
                            break;
                    }

                    Sign = Signs[numberWesternSign];
                }
                else
                {
                    IsCorrect = false;
                    Age = "-";
                    ChineseSign = "-";
                    Sign = "-";
                }
            }
        }

        public bool IsBirthday => DateTime.Today.Day == _birthDate.Day && DateTime.Today.Month == _birthDate.Month;
    }
}
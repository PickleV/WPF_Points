using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace _20210117_DataBinding

{
    public class ConverterBoolString : IValueConverter
    {
        //Bool to string
        public object Convert(object Value, Type dataType, object parameter, CultureInfo culture)
        {
            return Value.ToString();
        }



        //string to bool
        public object ConvertBack(object Input, Type dataType, object parameter, CultureInfo culture)
        {
            string s = Input.ToString().ToUpper();
            if (s == true.ToString().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;

namespace friendlyphonenumber.Models
{
    public class PhoneNumberFormatter
    {
        public long NumericPhoneNumber { get; set; }
        public string FormattedPhonenumber { get; set; }

        public void ConvertPhoneNumber () {
            FormattedPhonenumber = String.Format ("{0:(###) ###-####}", NumericPhoneNumber);
        }
    }
}
using System.Runtime.Serialization;

namespace friendlyphonenumber.Models
{
    [DataContract(Name="FormattedPhoneNumber")]
    public class FormattedPhoneNumber
    {
        [DataMember(Name="PhoneNumber")]
        public string PhoneNumber { get; set;}
    }
}
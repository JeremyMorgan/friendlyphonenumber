using System.Runtime.Serialization;

namespace friendlyphonenumber.Models
{   
    [DataContract(Name="NumericPhoneNumber")]
    public class NumericPhoneNumber
    {
        [DataMember(Name="PhoneNumber")]
        public long PhoneNumber { get; set;}
    }
}
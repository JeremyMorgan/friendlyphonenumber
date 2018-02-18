using Microsoft.AspNetCore.Mvc;
using friendlyphonenumber.Models;

namespace friendlyphonenumber.Controllers
{
    [Route("api/[controller]")]
    public class FormatPhoneNumber : Controller
    {
        PhoneNumberFormatter formatter = new PhoneNumberFormatter();

        public IActionResult Post([FromBody]NumericPhoneNumber phoneNumber)
        {

            if (phoneNumber != null ){

                formatter.NumericPhoneNumber = phoneNumber.PhoneNumber;
                formatter.ConvertPhoneNumber();
                FormattedPhoneNumber friendlyNumber = new FormattedPhoneNumber() { PhoneNumber = formatter.FormattedPhonenumber };
                return Ok(friendlyNumber);

            }else {
                return BadRequest();
            }
        }
    }
}
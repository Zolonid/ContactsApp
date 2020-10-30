using Newtonsoft.Json;

namespace ContactsApp
{
    public class PhoneNumber
    {
        /// <summary>
        /// Contains county code
        /// </summary>
        public string ZoneCode { get; private set; }

        /// <summary>
        /// Contains number (6 digits)
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Sets code of the county (first 3-4 numbers after (+7))
        /// </summary>
        /// <param name="zoneCode"></param>
        public void SetZoneCode(string zoneCode)
        {
            //TODO: Make validity check

            ZoneCode = zoneCode;
        }

        /// <summary>
        /// Set number without 
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void SetPhoneNumber(string phoneNumber)
        {
            //TODO: Make validity check

            Number = phoneNumber;
        }

        /// <summary>
        /// Default contructor with no parameters
        /// </summary>
        public PhoneNumber()
        {
            ZoneCode = "";
            Number = "";
        }

        /// <summary>
        /// Construtor for json
        /// </summary>
        /// <param name="ZoneCode"></param>
        /// <param name="number"></param>
        [JsonConstructor]
        public PhoneNumber(string zoneCode, string number)
        {
            ZoneCode = zoneCode;
            Number = number;
        }
    }
}

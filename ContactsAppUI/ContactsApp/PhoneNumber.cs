using System;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private string _zoneCode;
        private string _number;

        /// <summary>
        /// Contains zone code (3 digits after county code)
        /// </summary>
        public string ZoneCode
        {
            get => _zoneCode;
            set
            {
                if (value.Length > 3)
                    throw new ArgumentException("Zone code is too long.");

                _zoneCode = value;
            }
        }

        /// <summary>
        /// Contains number (up to 7 digits)
        /// </summary>
        public string Number
        {
            get => _number;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Number is too long.");

                _number = value;
            }
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
        /// Construtor with all parameters
        /// </summary>
        /// <param name="zoneCode"></param>
        /// <param name="number"></param>
        public PhoneNumber(string zoneCode, string number)
        {
            ZoneCode = zoneCode;
            Number = number;
        }
    }
}

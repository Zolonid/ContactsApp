using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Contact class that contains person's name, phone number, birthday, email and vk id.
    /// </summary>
    public class Contact : IComparable<Contact>
    {
        private string[] _name;
        private PhoneNumber _phoneNumber;
        private DateTime _birthday;
        private string _email;
        private string _vkid;

        /// <summary>
        /// Contains _contact's First name => [0], Middle name => [1] and Last name => [2] up to 50 characters.
        /// </summary>
        public string[] Name
        {
            get => _name;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Name is null.");

                for (int i = 0; i < 3; i++)
                {
                    if (value[i] != String.Empty)
                    {
                        if (value[i].Length > 50)
                            throw new ArgumentException("Name is too long.");

                        if (value[i] != string.Empty)
                            _name[i] = value[i].Substring(0, 1).ToUpper() + value[i].Substring(1).ToLower();
                    }
                    else throw new ArgumentException($"Name[{i}] is empty string.");
                }
            }
        }

        /// <summary>
        /// Contains _contact's number.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value ?? throw new ArgumentNullException("PhoneNumber is null.");
        }

        /// <summary>
        /// Contact's birtday (01.01.1900 to now).
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                //Date must be beetwen 01.01.1900 and now
                if (value.Year < 1900 || value > DateTime.Today)
                    throw new ArgumentException(message: "Birthday date cannot be sooner than 20 century and later than now.");

                _birthday = value;
            }
        }

        /// <summary>
        /// Contact's email (up to 50 characters).
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Email is too long.");

                _email = value;
            }
        }

        /// <summary>
        /// VK ID (everything after "vk.com/").
        /// </summary>
        public string VKID
        {
            get => _vkid;
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("VK ID is too long.");

                _vkid = value;
            }
        }

        /// <summary>
        /// Contructor with all parameters
        /// </summary>
        /// <param name="name">First name => [0], Middle name => [1] and Last name => [2], up to 50 characters.</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="birthday">From 01.01.1900 to now.</param>
        /// <param name="email">Up to 50 characters.</param>
        /// <param name="vkid">Up to 15 characters.</param>
        public Contact(string[] name, PhoneNumber phoneNumber, DateTime birthday, string email, string vkid)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Email = email;
            VKID = vkid;
        }

        /// <summary>
        /// Default contructor with no parametrs
        /// </summary>
        public Contact()
        {
            _name = new string[3];
            PhoneNumber = new PhoneNumber();
            Birthday = DateTime.Today;
        }

        /// <summary>
        /// Clone function for ISerializible
        /// </summary>
        /// <returns></returns>
        public Contact Clone()
        {
            Contact clone = new Contact(Name, PhoneNumber, Birthday, Email, VKID);
            return clone;
        }

        /// <summary>
        /// Return Person's name in form "Name MiddleName LastName"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var name = Name;
            return name[2] + " " + name[0] + " " + name[1];
        }

        /// <summary>
        /// Comparing order: LastName => Name => MiddleName
        /// </summary>
        public int CompareTo(Contact compareContact)
        {
            if (compareContact == null)
            {
                return 1;
            }
            else
            {
                if (compareContact.Name[2] != this.Name[2])
                {
                    return this.Name[2].CompareTo(compareContact.Name[2]);
                }
                else
                {
                    if (compareContact.Name[0] != this.Name[0])
                    {
                        return this.Name[0].CompareTo(compareContact.Name[0]);
                    }
                    else
                    {
                        return this.Name[1].CompareTo(compareContact.Name[1]);
                    }
                }
            }
        }
    }
}
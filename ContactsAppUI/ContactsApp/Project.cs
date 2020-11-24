using System;
using System.Collections.Generic;

namespace ContactsApp
{
    /// <summary>
    /// Wrapper class for contacts
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Holds existing contacts
        /// </summary>
        public List<Contact> ContactList;

        /// <summary>
        /// Default contructor with no parameters
        /// </summary>
        public Project()
        {
            ContactList = new List<Contact>(200);
        }

        /// <summary>
        /// Constructor that assigns specified contact list
        /// </summary>
        /// <param name="contactList">Maximim count of items in list is 200.</param>
        public Project(List<Contact> contactList)
        {
            if (contactList.Count > 200)
            {
                throw new ArgumentException("Contact list is too big.");
            }
            else
            {
                ContactList = contactList;
            }
        }

        /// <summary>
        /// Search contact's LastName for specified string
        /// </summary>
        public List<Contact> FindInLastName(string searchedString)
        {
            List<Contact> searchedList = new List<Contact>();

            foreach (var contact in ContactList)
            {
                if (contact.Name[2].Contains(searchedString))
                    searchedList.Add(contact);
            }

            return searchedList;
        }

        /// <summary>
        /// Search contact's MiddleName for specified string
        /// </summary>
        public List<Contact> FindInMiddleName(string searchedString)
        {
            List<Contact> searchedList = new List<Contact>();

            foreach (var contact in ContactList)
            {
                if (contact.Name[1].Contains(searchedString))
                    searchedList.Add(contact);
            }

            return searchedList;
        }

        /// <summary>
        /// Search contact's Name for specified string
        /// </summary>
        public List<Contact> FindInName(string searchedString)
        {
            List<Contact> searchedList = new List<Contact>();

            foreach (var contact in ContactList)
            {
                if (contact.Name[0].Contains(searchedString))
                    searchedList.Add(contact);
            }

            return searchedList;
        }

        /// <summary>
        /// Search contact's full name for specified string
        /// </summary>
        public List<Contact> FindInFullName(string searchedString)
        {
            List<Contact> searchedList = new List<Contact>();

            //Adds every found by Name
            searchedList.AddRange(this.FindInName(searchedString));

            //Adds only unique contacts found by MiddleName
            foreach (var contact in this.FindInMiddleName(searchedString))
            {
                if (!searchedList.Contains(contact))
                {
                    searchedList.Add(contact);
                }
            }

            //Adds only unique contacts found by LastName
            foreach (var contact in this.FindInLastName(searchedString))
            {
                if (!searchedList.Contains(contact))
                {
                    searchedList.Add(contact);
                }
            }

            return searchedList;
        }

        /// <summary>
        /// Search contact list for people with specified birthday
        /// </summary>
        public List<Contact> FindBirthdayBoy(DateTime date)
        {
            var returnList = new List<Contact>();

            foreach (var contact in ContactList)
            {
                if (contact.Birthday.Month == date.Month && contact.Birthday.Day == date.Day)
                {
                    returnList.Add((contact));
                }
            }

            return returnList;
        }
    }
}

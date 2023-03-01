using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Contact> Contacts = new();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
            // which does the same thing as this:
            // Contacts[contact.Email] = contact;
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }
    }
}

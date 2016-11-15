using System.Collections.Generic;

namespace JobBoard.Objects
{
    public class ContactInfo
    {
        private string _name;
        private string _email;
        private string _phone;

        public ContactInfo(string contactName, string contactEmail, string contactPhone)
        {
            _name = contactName;
            _email = contactEmail;
            _phone = contactPhone;
        }

        public void SetName(string contactName)
        {
            _name = contactName;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetEmail(string contactEmail)
        {
             _email = contactEmail;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetPhone(string contactPhone)
        {
            _phone = contactPhone;
        }

        public string GetPhone()
        {
            return _phone;
        }

    }
}

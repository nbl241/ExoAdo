using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAdo
{
    class People
    {
        #region Proprietes
        private string FullName;
        private string PreferredName;
        private string LogonName;
        private string PhoneNumber;
        private DateTime ValidFrom;
        private DateTime ValidTo;
        #endregion

        #region Constructeurs
        public People(string fullName, string preferredName, string logonName, string phoneNumbe, DateTime validFrom, DateTime validTo)
        {
            FullName = fullName;
            PreferredName = preferredName;
            LogonName = logonName;
            PhoneNumber = phoneNumbe;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
        #endregion

        #region Accesseurs
        public string fullName { get => FullName; set => FullName = fullName; }
        public string preferredName { get => PreferredName; set => PreferredName = preferredName; }
        public string logonName { get => LogonName; set => LogonName = logonName; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = phoneNumber; }
        public DateTime validFrom { get => ValidFrom; set => ValidFrom = validFrom; }
        public DateTime validTo { get => ValidTo; set => ValidTo = validTo; }
        #endregion

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4});{5}", FullName, PreferredName, LogonName, PhoneNumber, ValidFrom, ValidTo);
        }

    }
}

using System;

namespace AracKiralamaProjesi
{
    public class Customer
    {
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer(string fullName, string licenseNumber, DateTime birthDate)
        {
            FullName = fullName;
            LicenseNumber = licenseNumber;
            BirthDate = birthDate;
        }

        // Calculating age dynamically instead of storing it
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                // Check if birthday has passed this year
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}

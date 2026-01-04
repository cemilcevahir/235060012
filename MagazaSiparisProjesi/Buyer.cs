using System;

namespace MagazaSiparisProjesi
{
    public class Buyer
    {
        public string Username { get; set; }
        public decimal WalletBalance { get; set; }
        public DateTime MembershipDate { get; set; }

        public Buyer(string username, decimal initialBalance, DateTime membershipDate)
        {
            Username = username;
            WalletBalance = initialBalance;
            MembershipDate = membershipDate;
        }

        // Calculated Property: Membership duration in years
        // We don't store 'Years', we calculate it.
        public int MembershipYears
        {
            get
            {
                return DateTime.Today.Year - MembershipDate.Year;
            }
        }
    }
}

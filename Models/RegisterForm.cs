using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmirAliAkbari_CrudTest.Models
{
    [Table("RegisterForm", Schema = "dbo")]
    public class RegisterForm : BaseEntity<RegisterForm>
    {

        #region Methods

        public override bool Validate(ref List<string> Errors)
        {
            ///Validating Phone number here.
            ///Unique Email validated on database engine
            ///UniqueConstraint for DOB and ... also validated on database engine

            if (string.IsNullOrEmpty(FirstName))
                Errors.Add("First Name required");
            if (string.IsNullOrEmpty(LastName))
                Errors.Add("Last Name required");
            if (DateOfBirth == DateTime.MinValue)
                Errors.Add("Date of birth is not valid");
            if (string.IsNullOrEmpty(PhoneNumber))
                Errors.Add("PhoneNumber required");
            if (string.IsNullOrEmpty(Email))
                Errors.Add("Email required");
            if (string.IsNullOrEmpty(BankAccountNumber))
                Errors.Add("Bank Account Number required");

            if (Errors.Count == 0)
            {
                ///validating phone number

                var phoneUtil = PhoneNumbers.PhoneNumberUtil.GetInstance();
                try
                {
                    PhoneNumber NumberProto = phoneUtil.Parse(PhoneNumber, Country.ToUpper());
                    if (phoneUtil.GetNumberType(NumberProto) != PhoneNumberType.MOBILE)
                    {
                        Errors.Add("Phone number is not valid");
                    }
                }
                catch (NumberParseException e)
                {
                    Errors.Add("Phone number parsing error");
                }

            }

            return true;
        }

        #endregion

        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BankAccountNumber { get; set; }

        #endregion
    }
}
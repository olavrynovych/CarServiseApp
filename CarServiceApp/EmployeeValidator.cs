using CarServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarServiceApp
{
    public class EmployeeValidator
    {
        public static bool IsValidClientInfo(Employee employee)
        {
            if (!ValidateFirstOrSecondName(employee.FirstName))
            {
                return false;
            }
            if (!ValidateFirstOrSecondName(employee.LastName))
            {
                return false;
            }
            if (!ValidatePhoneNumber(employee.Phone, true))
            {
                return false;
            }

            return true;
        }

        public static bool ValidateFirstOrSecondName(string name)
        {
            if (name.Equals(string.Empty) || name.Length < 3)
            {
                return false;
            }

            return true;
        }

        public static bool ValidatePhoneNumber(string phone, bool IsRequired)
        {
            if (string.IsNullOrEmpty(phone) & !IsRequired)
                return true;

            if (string.IsNullOrEmpty(phone) & IsRequired)
                return false;

            var cleaned = RemoveNonNumeric(phone);
            if (IsRequired)
            {
                if (cleaned.Length == 10)
                    return true;
                else
                    return false;
            }
            else
            {
                if (cleaned.Length == 0)
                    return true;
                else if (cleaned.Length > 0 & cleaned.Length < 10)
                    return false;
                else if (cleaned.Length == 10)
                    return true;
                else
                    return false; // should never get here
            }
        }

        private static string RemoveNonNumeric(string phone)
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
        }
    }
}

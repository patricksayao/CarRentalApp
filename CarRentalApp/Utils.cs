using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Utils
    {        
        public static bool FormOpen(string name)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();

            var isOpen = OpenForms.Any(select => select.Name == name);

            return isOpen;
        }

        public static string HashPassword(string password)
        {
            /// HOW TO ENCRYPT ///////////////////////////////////////////
            SHA256 sha = SHA256.Create(); // format to use encryption

            // convert the input string to a byte array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // create a new StringBuilder to collect the bytes
            // and create a string
            StringBuilder stringBuilder = new StringBuilder();

            //loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            // the final output where the password is encrypted
            var hashed_password = stringBuilder.ToString();
            ////////////////////////////////////////////////

            return hashed_password;
        }

        public static string DefaultHashedPassword()
        {
            /// HOW TO ENCRYPT ///////////////////////////////////////////
            SHA256 sha = SHA256.Create(); // format to use encryption

            // convert the input string to a byte array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("Password@123"));

            // create a new StringBuilder to collect the bytes
            // and create a string
            StringBuilder stringBuilder = new StringBuilder();

            //loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            // the final output where the password is encrypted
            var hashed_password = stringBuilder.ToString();
            ////////////////////////////////////////////////

            return hashed_password;
        }
    }
}

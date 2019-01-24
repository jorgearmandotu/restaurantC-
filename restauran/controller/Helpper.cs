using Scrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace restauran.controller
{
    class Helpper
    {
        public string EncriptPwd(string pwd)
        {
            ScryptEncoder encoder = new ScryptEncoder();

            string hashsedPassword = encoder.Encode(pwd);
            return hashsedPassword;
        }

        public bool ComparePwd(string pwd, string passwordDb)
        {
            bool areEquals = false;
            ScryptEncoder encoder = new ScryptEncoder();
            areEquals = encoder.Compare(pwd, passwordDb);
            return areEquals;
        }
    }
}

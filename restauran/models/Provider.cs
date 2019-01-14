﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauran.models
{
    class Provider
    {
        private string id;
        private string name;
        private string phone;
        private string adress;
        private string email;
        private string others;

        public Provider(string id, string name, string phone, string adress, string email, string others)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Adress = adress;
            this.Email = email;
            this.Others = others;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Email { get => email; set => email = value; }
        public string Others { get => others; set => others = value; }
    }
}

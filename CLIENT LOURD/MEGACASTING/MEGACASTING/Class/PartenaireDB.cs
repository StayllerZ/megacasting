﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGACASTING.Class
{
    internal class PartenaireDB
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _mail;
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }


        public PartenaireDB()
        {

        }
    }
}

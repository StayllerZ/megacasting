using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGACASTING.Class
{
    internal class ClientDB
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

        private string _tel;
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        private string _mail;
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        private string _siret;
        public string Siret
        {
            get { return _siret; }
            set { _siret = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private int _id_packCasting;
        public int Id_packCasting
        {
            get { return _id_packCasting; }
            set { _id_packCasting = value; }
        }

        private int _nbr_rest_offre;
        public int Nbr_rest_offre
        {
            get { return _nbr_rest_offre; }
            set { _nbr_rest_offre = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGACASTINGLIB
{
    internal class CastingDB
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _libelle;
        public string Libelle
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        private string _reference;
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }

        private DateTime _dateDiffusion;
        public DateTime DateDiffusion
        {
            get { return _dateDiffusion; }
            set { _dateDiffusion = value; }
        }

        private DateTime _dateDebutCasting;
        public DateTime DateDebutCasting
        {
            get { return _dateDebutCasting; }
            set { _dateDebutCasting = value; }
        }

        private DateTime _dateFinCasting;
        public DateTime DateTimeFinCasting
        {
            get { return _dateFinCasting; }
            set { _dateFinCasting = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private decimal _ageMini;
        public decimal AgeMini
        {
            get { return _ageMini; }
            set { _ageMini = value; }
        }

        private decimal _ageMax;
        public decimal AgeMax
        {
            get { return _ageMax; }
            set { _ageMax = value; }
        }




        public CastingDB()
        {

        }
    }
}

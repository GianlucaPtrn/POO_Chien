using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Intro_13Sept
{
    class Chien
    {
        //attribut privé par covention commence par un "_" 
        private string _nom;
        private string _race;
        private int _age;

        //méthode publiques

        public String Nom
        {
            get { 
                return _nom; 
            }
            set {
                _nom = value; 
            }
        }

        public String Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        //le construteur
        public Chien(string nom, string race, int age)
        {
            this._nom = nom;
            this._race = race;
            this._age = age;
        }

        public string afficheCaracteristique()
        {
            string phrase = "Nom : " + _nom + "|" + " Age : " + _age + "|" + " Race : " + _race;
            return phrase;
        }
    }
}
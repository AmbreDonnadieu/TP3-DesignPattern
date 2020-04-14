using System.IO;
using System.Collections.Generic;

namespace UserPlugin
{
    class User
    {
        private string _Nom {get;set;}
        private string _Prenom{get;set;}
        private string _Email{get;set;}

        public User()
        {
            _Nom = "Nom";
            _Prenom = "Prenom";
            _Email = _Nom+"."+_Prenom+"@email.com"; 
        }

    }
}
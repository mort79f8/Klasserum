using System;
using System.Collections.Generic;
using System.Text;

namespace Klasserum.entities
{
    public class Teacher
    {
        private int id;
        private string firstname;
        private string lastname;
        private int classrum;
        private List<string> subjects;

        public Teacher(int id, string firstname, string lastname, int classrum, List<string> subjects)
        {            
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Classrum = classrum;
            Subjects = subjects;
        }

        public Teacher(string firstname, string lastname, List<string> subjects)
        {          
            Firstname = firstname;
            Lastname = lastname;            
            Subjects = subjects;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Classrum { get => classrum; set => classrum = value; }
        public List<string> Subjects { get => subjects; set => subjects = value; }
        public string Fullname { 
            get
            {
                return Firstname + " " + Lastname;
            }
        }
    }
}

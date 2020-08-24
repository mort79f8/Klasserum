using System;
using System.Collections.Generic;
using System.Text;

namespace Klasserum.entities
{
    public class Student
    {
        private int id;
        private string firstname;
        private string lastname;
        private int classrum;

        public Student(int id, string firstname, string lastname, int classrum)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Classrum = classrum;
        }

        public Student(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Classrum { get => classrum; set => classrum = value; }
        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Klasserum.entities
{
    public class Classroom
    {
        private int id;
        private string roomName;
        private string subject;
        private Teacher teacher;
        private List<Student> students;

        public Classroom(int id, string subject, Teacher teacher, List<Student> students, string roomName)
        {
            Id = id;
            Subject = subject;
            Teacher = teacher;
            Students = students;
            RoomName = roomName;
        }

        public Classroom(string roomName)
        {
            RoomName = roomName;
        }
        public Classroom()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Subject { get => subject; set => subject = value; }
        public Teacher Teacher { get => teacher; set => teacher = value; }
        public List<Student> Students { get => students; set => students = value; }
        public string RoomName { get => roomName; set => roomName = value; }
    }
}

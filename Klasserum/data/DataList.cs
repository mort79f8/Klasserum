using Klasserum.entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;

namespace Klasserum.Data
{
    public class DataList
    {    
        // Class rooms    
        public Classroom class1 = new Classroom("S-lokale");
        public Classroom class2 = new Classroom("V-lokale");
        public Classroom class3 = new Classroom("T-lokale");
        public Classroom class4 = new Classroom("Lab-lokale");

        // teachers        
        private Teacher t1 = new Teacher("Kale", "Kål", new List<string>() { "Teknik", "Lab" });
        private Teacher t2 = new Teacher("Jens", "Balde", new List<string>() { "Software Dev.", "Visualisering" });

        // Students
        private Student s1 = new Student("Hans", "Erik");
        private Student s2 = new Student("Asker", "Hansen");
        private Student s3 = new Student("Morten", "Tylle");
        private Student s4 = new Student("Ralf", "Jensen");
        private Student s5 = new Student("Jonas", "Rega");
        private Student s6 = new Student("Sofie", "Palse");
        private Student s7 = new Student("James", "Weggs");

        // populate the class rooms

        public DataList()
        {
            PopulateData();
        }
        
        private void PopulateData()
        {
            class1.Subject = "Software Dev.";
            class1.Teacher = t1;
            class1.Students = new List<Student>() { s1, s2, s3};
            
            class2.Teacher = t2;

        }

        public List<Classroom> ClassroomList()
        {
            List<Classroom> classroomList = new List<Classroom>();
            classroomList.Add(class1);
            classroomList.Add(class2);
            classroomList.Add(class3);
            classroomList.Add(class4);

            return classroomList;
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Entities.Subject;

namespace ERP.Entities.Student
{
    public struct Coordinate
    {
        public int x { get; set; }
        public int y { get; set; }
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Student: IStudent
    {
        private static int _NextStudentNumber = 0;
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _CI { get; set; }
        public int _StudentNumber { get; set; }
        public Coordinate _Coordinates { get; set; }
        

        public Student()
        {
            _Name = "";
            _LastName = "";
            _CI = "";
            _StudentNumber = _NextStudentNumber;
            _Coordinates = new Coordinate(0, 0);
            _NextStudentNumber++;
        }

        public override bool Equals(object obj)
        {
            Student aStudent = obj as Student;

            if (aStudent == null)
            {
                return false;
            }
            return this._StudentNumber== aStudent._StudentNumber;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string CI
        {
            get { return _CI; }
            set { _CI = value; }
        }
        public int StudentNumber
        {
            get { return _StudentNumber; }
            set { _StudentNumber = value; }
        }
        public Coordinate Coordinates
        {
            get { return _Coordinates; }
            set { _Coordinates = value; }
        }

    }

}

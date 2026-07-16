using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_crud_json
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class MedicalRecord
    {
        public string StudentId { get; set; } // Foreign key pointing to the Student's dictionary key
        public string employeeId { get; set; } // Foreign key pointing to the employee's dictionary key
        public string Date { get; set; }
        public string Department { get; set; }

        public string departmentId { get; set; }
        public string contactNumber { get; set; }

        public string sex { get; set; }
        public string Phone { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
    }

    internal class StudentMedicalViewModel
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string MedicalRecordKey { get; set; } // Used to uniquely identify the medical record for updates/deletes
    }



    internal class Employee
    {
        public string employeeId { get; set; }
        public string address { get; set; }
        public string birthDate { get; set; }
        public string contactNumber { get; set; }
        public string dateHired { get; set; }
        public string departmentId { get; set; }
        public string email { get; set; }
        public string employmentStatus { get; set; }
        public string firstName { get; set; }
        public int hourlyRate { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string position { get; set; }
        public string sex { get; set; }
    }

    internal class EmployeeMedicalViewModel
    {
        public string employeeId { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Date { get; set; }
        public string departmentId { get; set; }
        public string contactNumber { get; set; }

        public string sex { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string MedicalRecordKey { get; set; } // Used to uniquely identify the medical record for updates/deletes
    }


}

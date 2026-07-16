using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_crud_json
{
    // --- DATABASE MODELS ---
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Employee
    {
        public string firstName { get; set; } // Matching your camelCase usage
        public string lastName { get; set; }
        public string departmentId { get; set; }
    }

    public class MedicalRecord
    {
        public string StudentId { get; set; }
        public string employeeId { get; set; }
        public string Date { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string contactNumber { get; set; }
        public string sex { get; set; }
        public string departmentId { get; set; }
    }

    // --- VIEW MODELS FOR DATAGRIDVIEW ---
    public class StudentMedicalViewModel
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
        public string MedicalRecordKey { get; set; }
    }

    public class EmployeeMedicalViewModel
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
        public string MedicalRecordKey { get; set; }
    }

}

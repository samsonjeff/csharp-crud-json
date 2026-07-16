using System;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Net;
using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
// lib for firebase/firesharp
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Runtime.InteropServices;
using FireSharp;

namespace csharp_crud_json
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "h78I5J01gyPvGWahcnBsh0BqwVOCSvVZ3zn6uslG",
            BasePath = "https://it332-final-project-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        FirebaseClient firebaseClient;

        public Form1()
        {
            InitializeComponent();

            dataGridView.CellClick += dataGridView_CellContentClick;
        }




        // ====================================================
        //SAVE button
        private async void createBtn_Click(object sender, EventArgs e)
        {
            //FirebaseClient client = new FirebaseClient(config);

            //try
            //{
            //    Employee employee = new Employee
            //    {
            //       employeeId = textBoxID.Text,
            //        firstName = textBoxFirstName.Text,
            //        lastName = textBoxLastName.Text
            //    };
            //    //I would like to add a read button where all medical records will load in datagridview for all the student, for example the student 26 - 00001 has no record it will still show to the datagridview



            //    PushResponse response = await client.PushAsync("medical");
            //    dataGridView.DataSource = new List<MedicalRecord> {  };
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        // ====================================================




        // ====================================================
        //SEARCH button
        private async void readBtn_Click(object sender, EventArgs e)
        {

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            FirebaseResponse studentResponse = await client.GetAsync("student");
            FirebaseResponse medicalResponse = await client.GetAsync("medical");
            FirebaseResponse employeeResponse = await client.GetAsync("employee");

            try
            {    // Deserialize safely, defaulting to empty dictionaries if nodes are null
                var studentsDict = studentResponse.ResultAs<Dictionary<string, Student>>()
                                   ?? new Dictionary<string, Student>();

                var medicalDict = medicalResponse.ResultAs<Dictionary<string, MedicalRecord>>()
                                  ?? new Dictionary<string, MedicalRecord>();

                var employeesDict = employeeResponse.ResultAs<Dictionary<string, Employee>>()
                                    ?? new Dictionary<string, Employee>();

                // left join so students and employee without medical records are included
                var joinMedStudent = (from s in studentsDict
                                      join m in medicalDict on s.Key equals m.Value.StudentId into medicalGroup
                                      from subMedical in medicalGroup.DefaultIfEmpty()
                                      select new StudentMedicalViewModel
                                      {
                                          StudentId = s.Key,
                                          FirstName = s.Value?.FirstName ?? "N/A",
                                          LastName = s.Value?.LastName ?? "N/A",
                                          Date = subMedical.Value?.Date ?? "No Record",
                                          Department = subMedical.Value?.Department ?? "N/A",
                                          Phone = subMedical.Value?.Phone ?? "N/A",
                                          Purpose = subMedical.Value?.Purpose ?? "N/A",
                                          Remarks = subMedical.Value?.Remarks ?? "N/A",
                                          TimeIn = subMedical.Value?.TimeIn ?? "N/A",
                                          TimeOut = subMedical.Value?.TimeOut ?? "N/A",
                                          MedicalRecordKey = subMedical.Key // null if no record exists
                                      }).ToList();

                var joinMedEmployee = (from r in employeesDict
                                       join n in medicalDict on r.Key equals n.Value.employeeId into medicalGroups
                                       from subMedicals in medicalGroups.DefaultIfEmpty()
                                       select new EmployeeMedicalViewModel
                                       {
                                           employeeId = r.Key,
                                           firstName = r.Value?.firstName ?? "N/A",
                                           lastName = r.Value?.lastName ?? "N/A",
                                           Date = subMedicals.Value?.Date ?? "No Record",
                                           departmentId = subMedicals.Value?.employeeId ?? "N/A",
                                           contactNumber = subMedicals.Value?.contactNumber ?? "N/A",
                                           sex = subMedicals.Value?.sex ?? "N/A",
                                           Purpose = subMedicals.Value?.Purpose ?? "N/A",
                                           Remarks = subMedicals.Value?.Remarks ?? "N/A",
                                           TimeIn = subMedicals.Value?.TimeIn ?? "N/A",
                                           TimeOut = subMedicals.Value?.TimeOut ?? "N/A",
                                           MedicalRecordKey = subMedicals.Key // null if no record exists
                                       }).ToList();

                                            if (comboBox.SelectedIndex == 0)
                                            {
                                                dataGridView.DataSource = joinMedStudent;
                                            }
                                            else if (comboBox.SelectedIndex == 1)
                                            {
                                                dataGridView.DataSource = joinMedEmployee;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please select a valid option from the dropdown.");
                                            }
                    }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }
        // ====================================================




        // ====================================================
        //SAVE button
        private void updateBtn_Click(object sender, EventArgs e)
        {

        }
        // ====================================================





        // ====================================================
        // DELETE button
        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
        // ====================================================





        // ====================================================
        // SEARCH BOX
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        // ====================================================




        // ====================================================
        // TEST CONNECTION button
        private async void testConBtn_Click(object sender, EventArgs e)
        {
            FirebaseClient client = new FirebaseClient(config);
            try
            {
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {

                    FirebaseResponse testReponse = await client.GetAsync("medical");

                    if (testReponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Successfully Connected!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                searchBtn.Enabled = true;
            }
            // ====================================================


        }

        //private string _selectedEmployeeId = "";
        //private string _selectedEmployeeName = "";
        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0);

            //dataGridView.Rows[e.RowIndex].Selected = true;
            //medicalRecords.


        }

        private void InitializeFirebase()
        {
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(config);
                if (firebaseClient == null)
                {
                    MessageBox.Show("Failed to create Firebase client. Check configuration.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Firebase initialization error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
        //List<Employee> employees = new List<Employee>();

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.employeeId = textBoxID.Text;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.firstName = textBoxFirstName.Text;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.lastName = textBoxLastName.Text;
        }

        private void textBoxTimeIn_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.TimeIn = textBoxTimeIn.Text;
        }

        private void textBoxTimeOut_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.TimeOut = textBoxTimeOut.Text;
        }

        private void textBoxPurpose_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.Purpose = textBoxPurpose.Text;
        }

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.Remarks = textBoxRemarks.Text;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox.SelectedIndex = 0;
        }
    }
}

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
using System.Security.Cryptography;

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
            saveBtn.Enabled = false;
            //dataGridView.CellClick += dataGridView_CellContentClick;
        }

        private void clearTextBox(){
            textBoxID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxDepartment.Clear();
            textBoxDate.Clear();
            textBoxPurpose.Clear();
            textBoxRemarks.Clear();
            textBoxTimeIn.Clear();
            textBoxTimeOut.Clear();
            }


        // ====================================================
        //SAVE button
        private async void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
            FirebaseClient client = new FirebaseClient(config);
            FirebaseResponse studentResponse = await client.GetAsync("student");
            FirebaseResponse employeeResponse = await client.GetAsync("employees");

            var tempId = textBoxID.Text;

                if (tempId == null) 
                {
                    MessageBox.Show("Select user from the table");
                    return;
                }


                FirebaseResponse currentResponse = await client.GetAsync("medical");
                var medDict = currentResponse.ResultAs<Dictionary<string, MedicalRecord>>();

                int maxId = 0;


                if (medDict != null)
                {
                    foreach (var k in medDict.Keys)
                    {
                        if (k.StartsWith("MR-") && int.TryParse(k.Substring(3), out int currentId))
                            if (currentId > maxId)
                            {
                                maxId = currentId;
                            }
                    }
                }

                int nexthop = maxId + 1;
                string medicalId = $"MR-{nexthop:D4}";


                
                    var setMedicalRecord = new MedicalRecord()
                    {

                        StudentId = comboBox.SelectedIndex == 0 ? textBoxID.Text.Trim() : null,
                        employeeId = comboBox.SelectedIndex == 1 ? textBoxID.Text.Trim() : null,
                        FirstName = textBoxFirstName.Text.Trim(),
                        LastName = textBoxLastName.Text.Trim(),
                        ProgramId = textBoxDepartment.Text.Trim(),
                        Date = textBoxDate.Text.Trim(),
                        Purpose = textBoxPurpose.Text.Trim(),
                        Remarks = textBoxRemarks.Text.Trim(),
                        TimeIn = textBoxTimeIn.Text.Trim(),
                        TimeOut = textBoxTimeOut.Text.Trim()

                    };


                if (string.IsNullOrEmpty(textBoxID.Text) && string.IsNullOrEmpty(textBoxFirstName.Text))
                {
                    MessageBox.Show("Complete the form to save");
                    return;
                }
                else
                {
                    FirebaseResponse response = await client.SetAsync($"medical/{medicalId}", setMedicalRecord);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Successfully Added!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clearTextBox();
            }
            


        }
        // ====================================================




        // ====================================================
        //SEARCH button
        private async void readBtn_Click(object sender, EventArgs e)
        {

            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            FirebaseResponse studentResponse = await client.GetAsync("students");
            FirebaseResponse medicalResponse = await client.GetAsync("medical");
            FirebaseResponse employeeResponse = await client.GetAsync("employees");

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
                                          ProgramId = subMedical.Value?.ProgramId ?? s.Value?.ProgramId ?? "N/A",
                                          ContactNumber = subMedical.Value?.ContactNumber ?? s.Value?.ContactNumber ?? "N/A",
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
                                           departmentId = subMedicals.Value?.departmentId ?? r.Value?.departmentId ?? "N/A", // Fixed typo here
                                           contactNumber = subMedicals.Value?.contactNumber ?? r.Value?.contactNumber ?? "N/A",
                                           //sex = subMedicals.Value?.sex ?? "N/A",
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
            finally
            {
                saveBtn.Enabled = true;
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
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0){
                saveBtn.Enabled = false;
                return;}

            var selected = dataGridView.Rows[e.RowIndex];
            selected.Selected = true;

            if(selected.DataBoundItem is StudentMedicalViewModel studentViewMedical)
            {
                textBoxID.Text = studentViewMedical.StudentId;
                textBoxFirstName.Text = studentViewMedical.FirstName;
                textBoxLastName.Text = studentViewMedical.LastName;
                textBoxDepartment.Text = studentViewMedical.ProgramId;
                textBoxDate.Text = studentViewMedical.Date;
                textBoxPurpose.Text = studentViewMedical.Purpose;
                textBoxRemarks.Text = studentViewMedical.Remarks;
                textBoxTimeIn.Text = studentViewMedical.TimeIn;
                textBoxTimeOut.Text = studentViewMedical.TimeOut;
            }else if (selected.DataBoundItem is EmployeeMedicalViewModel employeeViewMedical)
            {
                textBoxID.Text = employeeViewMedical.employeeId;
                textBoxFirstName.Text = employeeViewMedical.firstName;
                textBoxLastName.Text = employeeViewMedical.lastName;
                textBoxDepartment.Text = employeeViewMedical.departmentId;
                textBoxDate.Text = employeeViewMedical.Date;
                textBoxPurpose.Text = employeeViewMedical.Purpose;
                textBoxRemarks.Text = employeeViewMedical.Remarks;
                textBoxTimeIn.Text = employeeViewMedical.TimeIn;
                textBoxTimeOut.Text = employeeViewMedical.TimeOut;

            }

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

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            //IFirebaseClient client = new FireSharp.FirebaseClient(config);
            //string findID = textBoxID.Text.Trim();

            textBoxID.ReadOnly = true;

            //if (!string.IsNullOrEmpty(findID))
            //{
            //    //textBoxFirstName.Text = "----";
            //    return;
            //}

            //try
            //{
            //    if (comboBox.SelectedIndex == 0)
            //    {
            //        FirebaseResponse responseStudent = client.Get("student/" + findID);

            //        if (responseStudent.Body != null)
            //        {
            //            var student = responseStudent.ResultAs<Student>();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Not Found!");
            //            textBoxID.Focus();
            //        }
            //    }
            //    else
            //    {
            //        FirebaseResponse responseEmployee = client.Get("employees/" + findID);

            //        if (responseEmployee.Body != null)
            //        {
            //            var student = responseEmployee.ResultAs<Student>();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Not Found!");
            //            textBoxID.Focus();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error fetching student data: {ex.Message}");


            //}
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            textBoxFirstName.ReadOnly = true;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            textBoxLastName.ReadOnly = true;
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
            clearTextBox();
        }

        private void textBoxSex_TextChanged(object sender, EventArgs e)
        {
            textBoxDepartment.ReadOnly = true;
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            //destinatio = source
            medical.Date = textBoxDate.Text;
        }
    }
}

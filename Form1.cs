using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
// lib for firebase/firesharp
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

// code by: https://github.com/samsonjeff

namespace csharp_crud_json
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        IFirebaseConfig config;
        IFirebaseClient FirebaseClient;



        public Form1()
        {
            InitializeComponent();
            //dataGridView.CellClick += dataGridView_CellContentClick;
            //searchBtn.Enabled = false;
            saveBtn.Enabled = false;
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;

            var env = LoadEnv(".env");

            config = new FirebaseConfig
            {
                AuthSecret = env.GetValueOrDefault("FIREBASE_SECRET"),
                BasePath = env.GetValueOrDefault("FIREBASE_URL")
            };

        }

        private Dictionary<string, string> LoadEnv(string filePath)
        {
            var env = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

            if (!File.Exists(fullPath))
                fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);

            if (!File.Exists(fullPath)) return env;

            foreach (var line in File.ReadAllLines(fullPath))
            {
                var trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith("#")) continue;

                var parts = trimmed.Split(new[] { '=' }, 2);
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }
                    env[key] = value;
                }
            }
            return env;
        }

        private void clearTextBox()
        {
            textBoxID.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxDepartment.Clear();
            textBoxDate.Clear();
            textBoxPurpose.Clear();
            textBoxRemarks.Clear();
            textBoxTimeIn.Clear();
            textBoxTimeOut.Clear();
            textBoxStatus.Clear();
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


                if (string.IsNullOrEmpty(textBoxDate.Text) && string.IsNullOrEmpty(textBoxPurpose.Text) && string.IsNullOrEmpty(textBoxRemarks.Text))
                {
                    MessageBox.Show("Complete the form to save");
                    return;
                }

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
                    Status = textBoxStatus.Text.Trim(),
                    TimeIn = textBoxTimeIn.Text.Trim(),
                    TimeOut = textBoxTimeOut.Text.Trim()

                };




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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await LoadData();
                //clearTextBox();
            }

        }
        // ====================================================




        // ====================================================
        //SEARCH button
        private async void readBtn_Click(object sender, EventArgs e)
        {
            await LoadData(); 
        }
        // ====================================================




        // ====================================================
        //SAVE button
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            FirebaseClient client = new FireSharp.FirebaseClient(config);
            try
            {
                string? medId = textBoxMedId.Text.Trim();
                if (string.IsNullOrEmpty(medId))
                {
                    MessageBox.Show("User has no record!"); return;
                }

                var updateMedRecord = new MedicalRecord()
                {

                    StudentId = comboBox.SelectedIndex == 0 ? textBoxID.Text.Trim() : null,
                    employeeId = comboBox.SelectedIndex == 1 ? textBoxID.Text.Trim() : null,
                    FirstName = textBoxFirstName.Text.Trim(),
                    LastName = textBoxLastName.Text.Trim(),
                    ProgramId = textBoxDepartment.Text.Trim(),
                    Date = textBoxDate.Text.Trim(),
                    Purpose = textBoxPurpose.Text.Trim(),
                    Remarks = textBoxRemarks.Text.Trim(),
                    Status = textBoxStatus.Text.Trim(),
                    TimeIn = textBoxTimeIn.Text.Trim(),
                    TimeOut = textBoxTimeOut.Text.Trim(),

                };

                if (string.IsNullOrEmpty(textBoxMedId.Text))
                {
                    MessageBox.Show("No Record for this user!");
                    return;
                }
                else
                {
                    FirebaseResponse response = await client.UpdateAsync($"medical/{medId}", updateMedRecord);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Record {medId} successfully update!");
                    }
                    else
                    {
                        MessageBox.Show($"Record {medId} failed to update!");
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
        // DELETE button
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string findID = textBoxMedId.Text.Trim();
                if (string.IsNullOrEmpty(findID))
                {
                    MessageBox.Show("Select User With Record!");
                    return;
                }

                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete record {findID}?",   // text
                    "Confirm to Delete",                                    // caption
                    MessageBoxButtons.OKCancel,                             // buttons
                    MessageBoxIcon.Warning // new discovery koto :D             // icon
                );

                if (confirmResult == DialogResult.OK && textBoxMedId != null)
                {
                    FirebaseClient responseDelete = new FirebaseClient(config);
                    FirebaseResponse setDelete = await responseDelete.DeleteAsync($"medical/{findID}");

                    if (setDelete.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Deleted Successfully!");
                    }
                    else
                    {

                        MessageBox.Show("Faild to Delete!");
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
                await LoadData();
            }
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

            // ====================================================


        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                saveBtn.Enabled = false;
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
                return;
            }

            var selected = dataGridView.Rows[e.RowIndex];
            selected.Selected = true;

            if (selected.DataBoundItem is StudentMedicalViewModel studentViewMedical)
            {
                textBoxID.Text = studentViewMedical.StudentId;
                textBoxFirstName.Text = studentViewMedical.FirstName;
                textBoxLastName.Text = studentViewMedical.LastName;
                textBoxDepartment.Text = studentViewMedical.ProgramId;
                textBoxDate.Text = studentViewMedical.Date;
                textBoxPurpose.Text = studentViewMedical.Purpose;
                textBoxRemarks.Text = studentViewMedical.Remarks;
                textBoxStatus.Text = studentViewMedical.Status;
                textBoxTimeIn.Text = studentViewMedical.TimeIn;
                textBoxTimeOut.Text = studentViewMedical.TimeOut;
                textBoxMedId.Text = studentViewMedical.MedicalRecordKey;
            }
            else if (selected.DataBoundItem is EmployeeMedicalViewModel employeeViewMedical)
            {
                textBoxID.Text = employeeViewMedical.employeeId;
                textBoxFirstName.Text = employeeViewMedical.firstName;
                textBoxLastName.Text = employeeViewMedical.lastName;
                textBoxDepartment.Text = employeeViewMedical.departmentId;
                textBoxDate.Text = employeeViewMedical.Date;
                textBoxPurpose.Text = employeeViewMedical.Purpose;
                textBoxRemarks.Text = employeeViewMedical.Remarks;
                textBoxStatus.Text = employeeViewMedical.Status;
                textBoxTimeIn.Text = employeeViewMedical.TimeIn;
                textBoxTimeOut.Text = employeeViewMedical.TimeOut;
                textBoxMedId.Text = employeeViewMedical.MedicalRecordKey;

            }

        }

        private void InitializeFirebase()
        {
            try
            {
                FirebaseClient = new FireSharp.FirebaseClient(config);
                if (FirebaseClient == null)
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

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = true;
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
            dataGridView.DataSource = null;
            clearTextBox();
            if (comboBox.SelectedIndex == 0 && comboBox.SelectedIndex == 1)
            {
                clearTextBox();
            }
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

        private void textBoxMedId_TextChanged(object sender, EventArgs e)
        {
            textBoxMedId.ReadOnly = true;
            textBoxMedId.Visible = false;
        }

        private void labelForPatientType_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

            MedicalRecord medical = new MedicalRecord();
            medical.Status = textBoxPurpose.Text;
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxStatus.Text = comboBoxStatus.Text;
        }

        private async Task LoadData(){
            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            FirebaseResponse studentResponse = await client.GetAsync("students");
            FirebaseResponse medicalResponse = await client.GetAsync("medical");
            FirebaseResponse employeeResponse = await client.GetAsync("employees");

            //Console.WriteLine($"Students response: {studentResponse.StatusCode}");

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
                                          Date = subMedical.Value?.Date ?? "",
                                          ProgramId = subMedical.Value?.ProgramId ?? s.Value?.ProgramId ?? "N/A",
                                          ContactNumber = subMedical.Value?.ContactNumber ?? s.Value?.ContactNumber ?? "N/A",
                                          Purpose = subMedical.Value?.Purpose ?? "",
                                          Remarks = subMedical.Value?.Remarks ?? "",
                                          Status = subMedical.Value?.Status ?? "",
                                          TimeIn = subMedical.Value?.TimeIn ?? "",
                                          TimeOut = subMedical.Value?.TimeOut ?? "",
                                          MedicalRecordKey = subMedical.Key ?? ""
                                      }).ToList();

                var joinMedEmployee = (from r in employeesDict
                                       join n in medicalDict on r.Key equals n.Value.employeeId into medicalGroups
                                       from subMedicals in medicalGroups.DefaultIfEmpty()
                                       select new EmployeeMedicalViewModel
                                       {
                                           employeeId = r.Key,
                                           firstName = r.Value?.firstName ?? "N/A",
                                           lastName = r.Value?.lastName ?? "N/A",
                                           Date = subMedicals.Value?.Date ?? "",
                                           departmentId = subMedicals.Value?.departmentId ?? r.Value?.departmentId ?? "N/A",
                                           contactNumber = subMedicals.Value?.contactNumber ?? r.Value?.contactNumber ?? "N/A",
                                           //sex = subMedicals.Value?.sex ?? "N/A",
                                           Purpose = subMedicals.Value?.Purpose ?? "",
                                           Remarks = subMedicals.Value?.Remarks ?? "",
                                           Status = subMedicals.Value?.Status ?? "",
                                           TimeIn = subMedicals.Value?.TimeIn ?? "",
                                           TimeOut = subMedicals.Value?.TimeOut ?? "",
                                           MedicalRecordKey = subMedicals.Key ?? ""
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
                    MessageBox.Show("Select Patient Type!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
            finally
            {
                saveBtn.Enabled = true;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
                clearTextBox();
            }
        }
    }
}

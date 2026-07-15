using System.Windows.Forms;
using System.Text.Json;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Net;
using System.Net.Http;
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
        public Form1()
        {
            InitializeComponent();
        }


        FirebaseClient firebaseClient;

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "h78I5J01gyPvGWahcnBsh0BqwVOCSvVZ3zn6uslG",
            BasePath = "https://it332-final-project-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };


        // ====================================================
        //SAVE button
        private async void createBtn_Click(object sender, EventArgs e)
        {
            FirebaseClient client = new FirebaseClient(config);

            try
            {
                Employee employee = new Employee
                {
                    id = textBoxID.Text,
                    firstName = textBoxFirstName.Text,
                    lastName = textBoxLastName.Text
                };




                PushResponse response = await client.PushAsync("medical");
                dataGridView.DataSource = new List<MedicalRecord> {  };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ====================================================




        // ====================================================
        //SEARCH button
        private async void readBtn_Click(object sender, EventArgs e)
        {
            FirebaseClient client = new FirebaseClient(config);
            List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
            List<Employee> employees = new List<Employee>();

            try
            {
                string? showID = textBoxID.Text.Trim();
                showID = medicalRecords.FirstOrDefault(m => m.employeeId == showID)?.employeeId;

                if (!string.IsNullOrEmpty(showID))
                {
                    showID = Clipboard.GetText().Trim();
                }

                MedicalRecord medical = new MedicalRecord();
                Employee employee = new Employee();

                

                

                FirebaseResponse response = await client.GetAsync("medical");
                if (response.Body != null)
                {
                    MedicalRecord log = response.ResultAs<MedicalRecord>();

                    dataGridView.DataSource = log;

                    MessageBox.Show($"Record found!");
                }
                else
                {
                    FirebaseResponse responseNewNode = await client.GetAsync("medical");
                    MessageBox.Show($"No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
            employee.id = textBoxID.Text;
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
            medical.timeIn = textBoxTimeIn.Text;
        }

        private void textBoxTimeOut_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.timeOut = textBoxTimeOut.Text;
        }

        private void textBoxPurpose_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.purpose = textBoxPurpose.Text;
        }

        private void textBoxRemarks_TextChanged(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord();
            medical.remarks = textBoxRemarks.Text;
        }
    }
}

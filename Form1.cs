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

namespace csharp_crud_json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        IFirebaseClient client;
        string url = @"";

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "h78I5J01gyPvGWahcnBsh0BqwVOCSvVZ3zn6uslG",
            BasePath = "https://it332-final-project-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };



        // ====================================================
        //SAVE button
        private void createBtn_Click(object sender, EventArgs e)
        {


        }
        // ====================================================





        // ====================================================
        //SEARCH button
        private async void readBtn_Click(object sender, EventArgs e)
        {

            string readAll = await File.ReadAllTextAsync("input the link here");

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
            searchBtn.Enabled = false;
            try
            {
                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {

                    FirebaseResponse testReponse = await client.GetAsync("/");

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
    }
}

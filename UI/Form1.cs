using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BL.Models;

namespace UI
{
    public partial class Form1 : Form
    {
        List<ClosestAgent> _list = new List<ClosestAgent>();
        BLClass BL = new BLClass();

        public Form1()
        {
            InitializeComponent();
            // hide the browser panel
            //webBrowser1.ScriptErrorsSuppressed = true;
            // hide the map till user clicks the button to show it.
            webBrowser1.Hide();

            //
            // Init the DGV to suits our needs 
            dgvAgents.AutoGenerateColumns = false;
            dgvAgents.ColumnCount = 2;
            dgvAgents.Columns[0].HeaderText = "Name";
            dgvAgents.Columns[0].DataPropertyName = "Name";
            dgvAgents.Columns[1].HeaderText = "Distance";
            dgvAgents.Columns[1].DataPropertyName = "Distance";

            GetAgents();
        }

        private void GetAgents()
        {
           _list = BL.GetCloestAgent();

            // used for extracting the data that we need to string format
            // var combined = string.Join(",", list.Select(c => c.Name.ToString() + " " + c.ToLat.ToString() + " " + c.ToLng.ToString()));

            dgvAgents.DataSource = _list;
        }

        private void btnShowOnMap_Click(object sender, EventArgs e)
        {
            try
            {
                string curDir = Directory.GetCurrentDirectory();

                //
                // google.html is set to be Copy To Output directory if newer
                // this.webBrowser1.Url = new Uri(String.Format(@"file://{0}\WebAssets\google.html", curDir));
                BL.JsonToFile(_list);
                // loadGeoJson() function cant load local file, like file://coordinate.json
                // so it need to be hostedin IIS
                this.webBrowser1.Url = new Uri("http://localhost/googlemap/");
                // 
                // Show the map
               webBrowser1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.ToString());
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Mongo
{
    public partial class Carer : Form
    {

        private MongoClient _mongo;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection<CarerObj> _carers;

        public Carer()
        {
            InitializeComponent();

            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");
            // Using generics here means that we dont not need to use "find as" when accessing data in the collection
            _carers = _database.GetCollection<CarerObj> ("Carers");
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            populateForm();
        }

        private void populateForm()
        {

            var carer = GetCarerByID(txtFindID.Text.Trim());

            txtForename.Text = carer.Carerforename;
            txtSurname.Text = carer.surname;
            txtId.Text = carer.CarerID;
        }

        public CarerObj GetCarerByID(string carerId)
        {
            return _carers.FindOneById(ObjectId.Parse(carerId));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var carer = GetCarerByID(txtId.Text);
            carer.Carerforename = txtForename.Text;
            carer.surname = txtSurname.Text;

            _carers.Save(carer);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtForename.Text = string.Empty;
            txtSurname.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CarerObj carer = new CarerObj();
            carer.Carerforename = txtForename.Text;
            carer.surname = txtSurname.Text;
            _carers.Insert(carer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = ObjectId.Parse(txtId.Text);
            var query = Query.EQ("_id", id);
            _carers.Remove(query); 
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            txtResults.Text = GetAllCarers().ToString();
        }

        private CarerObjs GetAllCarers()
        {
            // Finds in mongo return cursors
            // Cursors do not return data until the individual intem in the cursor is used
            // Each iteration of the cursor below is getting the data from mongo as Mongo.CarerObj and maps to CarerObj so it can be added to carerObjs

            CarerObjs Carers = new CarerObjs();
            var CarersFound = _carers.FindAll();
            foreach (var carer in CarersFound)
            {
                Carers.Add(carer);
            }
            return Carers;
        }


    }


}

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

namespace Mongo
{
    public partial class Carer : Form
    {

        private MongoClient _mongo;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection _carers;

        public Carer()
        {
            InitializeComponent();

            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");
            _carers = _database.GetCollection("Carers");
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            populateForm();
        }

        private void populateForm()
        {

            var carer = GetCarerByID("54c2060e1219e78de345718e");

            txtForename.Text = carer.forename;
            txtSurname.Text = carer.surname;
        }

        public CarerObj GetCarerByID(string carerId)
        {
            return _carers.FindOneByIdAs<CarerObj>(ObjectId.Parse(carerId));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var carer = GetCarerByID("54c2060e1219e78de345718e");
            carer.forename = txtForename.Text;
            carer.surname = txtSurname.Text;

            _carers.Save(carer);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtForename.Text = string.Empty;
            txtSurname.Text = string.Empty;
        }
    }

    public class CarerObj
    {
        public ObjectId _id;
        public string forename;
        public string surname;
    }
}

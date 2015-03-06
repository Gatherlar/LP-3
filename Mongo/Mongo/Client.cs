using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace Mongo
{
    public partial class Client : Form
    {

        private MongoClient _mongo;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection _clients;

        public Client()
        {
            InitializeComponent();

            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");
            _clients = _database.GetCollection("Clients");

        }

        private void populateForm()
        {

            var client = GetClientByID("54c206d91219e78de345718f");

            txForename.Text = client.forename;
            txSurname.Text = client.surname;
        }

        private void btnPopulate_Click(object sender, System.EventArgs e)
        {
            populateForm();
        }

        private ClientObj GetClientByID(string clientId)
        {
            return _clients.FindOneByIdAs<ClientObj>(ObjectId.Parse(clientId));
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var client = GetClientByID("54c206d91219e78de345718f");
            client.forename = txForename.Text;
            client.surname = txSurname.Text;

            _clients.Save(client);
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txForename.Text = string.Empty;
            txSurname.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var client = new BsonDocument
            {
                {"forename", txForename.Text}, 
                {"surname " ,txSurname.Text}
            };
            _clients.Insert(client);
        }


    }

}

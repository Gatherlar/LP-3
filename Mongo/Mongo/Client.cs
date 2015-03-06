using System;
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
            ClientsObj myClients;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                myClients = GetAllClients();
            }
            else
            {
                myClients = new ClientsObj();
                myClients.Add(GetClientByID(txtId.Text));
            }
      

            txForename.Text = myClients[0].forename;
            txSurname.Text = myClients[0].surname;
            txtId.Text = myClients[0]._id.ToString();
        }

        private void btnPopulate_Click(object sender, System.EventArgs e)
        {
            populateForm();
        }

        private ClientsObj GetAllClients()
        {
            ClientsObj myClients = new ClientsObj();
            var clients = _clients.FindAllAs<ClientObj>();

            foreach (var client in clients)
            {
                myClients.Add(client);
            }

            return myClients;
        }

        private ClientObj GetClientByID(string clientId)
        {
            return _clients.FindOneByIdAs<ClientObj>(ObjectId.Parse(clientId));
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var client = GetClientByID(txtId.Text);
            client.forename = txForename.Text;
            client.surname = txSurname.Text;

            _clients.Save(client);
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txForename.Text = string.Empty;
            txSurname.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var client = new BsonDocument
            {
                {"forename", txForename.Text}, 
                {"surname" ,txSurname.Text}
            };
            _clients.Insert(client);
        }

        private void btnFindAll_Click(object sender, System.EventArgs e)
        {
            ClientsObj myClients;

            myClients = GetAllClients();


            txtResults.Text = myClients.ToString();
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            txtResults.Text = String.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // To Do
            //_clients.Remove(Query.EQ("_id", txtId.Text));
        }


    }

}

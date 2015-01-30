using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo
{
    public partial class ClientFind : Form
    {
        private MongoClient _mongo;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection _clients;


        public ClientFind()
        {
            InitializeComponent();

            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");
            _clients = _database.GetCollection("Clients");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var Clients = _clients.FindAllAs<ClientObj>();
            ClientsObj myClients = new ClientsObj();

            foreach (var client in Clients)
            {
                myClients.Add(client);
            }


            txtResults.Text = myClients.ToString();
            dgvClients.DataSource = myClients;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResults.Text = string.Empty;
        }

 
    }
}

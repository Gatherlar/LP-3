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


        public Client()
        {
            InitializeComponent();

            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");

            populateForm();
        }

        private void populateForm()
        {
            MongoCollection clients = _database.GetCollection("Clients");
            var chris = clients.FindOneByIdAs<ClientObj>(ObjectId.Parse("54c206d91219e78de345718f"));

            txForename.Text = chris.forename;
            txSurname.Text = chris.surname;
        }


    }

    public class ClientObj
    {
        public ObjectId _id;
        public string forename;
        public string surname;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Mongo
{
    class VisitsObj
    {
        private MongoClient _mongo;
        private MongoServer _server;
        private MongoDatabase _database;
        private MongoCollection<VisitObj> _visit;


        public VisitObj(string visitID)
        {
            _mongo = new MongoClient();
            _server = _mongo.GetServer();
            _database = _server.GetDatabase("CMdb");
            // Using generics here means that we dont not need to use "find as" when accessing data in the collection
            _visit = _database.GetCollection<VisitObj> ("Visits");
            Populate(visitID);
        }

        private VisitObj Populate(string visitID)
        {
           var visit =  _visit.FindOneByIdAs<VisitObj>(ObjectId.Parse(visitID));
           return visit;

        }


    }
}





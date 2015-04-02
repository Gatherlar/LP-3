using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Mongo
{
    public class VisitObj
    {

        [BsonId]
        public ObjectId _id;

        public ObjectId idClient;
        public ObjectId idCarer;
        public DateTime VisitStart;
        public DateTime VisitEnd;
        public string ClientName;
        public string CareName;

        [BsonIgnore]
        public ClientObj client;
        [BsonIgnore]
        public CarerObj carer;


    }
}

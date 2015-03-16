using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo
{
    public class CarerObj
    {
        [BsonId]
        private ObjectId _CarerID;

        [BsonIgnore]
        public string CarerID
        {
            get { return _CarerID.ToString(); }
            set { _CarerID = ObjectId.Parse(value); }
        }
        

        [BsonElement("forename")]
        public string Carerforename;
        public string surname;

        [BsonIgnore]
        public int age;
    }
}



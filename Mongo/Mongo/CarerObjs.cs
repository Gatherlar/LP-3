using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Mongo
{
    class CarerObjs : List<CarerObj>
    {

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var carer in this)
            {
                sb.AppendLine(string.Format("ID: {0} Forename: {1} Surname: {2}", carer.CarerID , carer.Carerforename, carer.surname));
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo
{
    public class ClientsObj: List<ClientObj>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var client in this)
            {
                sb.AppendLine(string.Format("ID: {0} Forename: {1} Surname: {2}", client._id, client.forename, client.surname));
            }

            return sb.ToString();
        }
    }
}

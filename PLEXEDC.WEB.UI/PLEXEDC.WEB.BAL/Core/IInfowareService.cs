using PLEXEDC.WEB.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEXEDC.WEB.BAL.Core
{
    public interface IInfowareService
    {
        List<CSCSNumber> GetCSCSNumber(string SessionId, string InfowareId);

        List<StockList> GetPortFolio(string SessionId, string InfowareId);

        List<Transaction> GetAccountOverView(string SessionId, string InfowareId);

        List<OpenOrder> GetOpenOrder(string SessionId, string InfowareId);
    }
}

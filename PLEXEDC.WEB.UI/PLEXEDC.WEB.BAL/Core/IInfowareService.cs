using PLEXEDC.WEB.DAL.Models;
using System.Collections.Generic;

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

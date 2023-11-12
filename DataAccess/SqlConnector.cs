using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibary.Modals;
using System.Data;
using Dapper;


// @PlaceName nvarchar(50),
//	@PLaceNumber int,
//	@PrizeAmount money,
//    @PrizePercentage float,
namespace TrackerLibary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// saves prize to the database
        /// </summary>
        /// <param name="modal">the prize information </param>
        /// <returns> the prize information, include the unique identifier.</returns>
        public PrizeModal CreatePrize(PrizeModal modal)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournament")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceName", modal.PlaceName);
                p.Add("@PLaceNumber", modal.PlaceNumber);
                p.Add("@PrizeAmount", modal.PrizeAmount);
                p.Add("@PrizePercentage", modal.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                modal.Id = p.Get<int>("Id");

                return modal;
            }
        }
    }
}

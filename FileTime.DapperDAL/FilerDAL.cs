using Dapper;
using FileTime.DAO;
using FileTime.IDAL;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileTime.DapperDAL
{
	public class FilerDAL : IFilerDAL
	{
		private IConfigurationRoot _config = null;
		public FilerDAL()
		{
			_config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
		}

		public async Task<Filer> GetAndUpdateFiler(string emailAddress, string efmFilerId, string password)
		{
			Filer objFiler = null;
			using (IDbConnection con = new SqlConnection(_config.GetConnectionString("your-connection-string")))
			{
				if (con.State == ConnectionState.Closed)
					con.Open();
				DynamicParameters parameter = new DynamicParameters();
				parameter.Add("@emailAddress", emailAddress);
				parameter.Add("@efmFilerId", efmFilerId);
				parameter.Add("@password", password);
				objFiler = con.Query<Filer>("FTSP_GetAndUpdateFiler", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
			}
			return objFiler;
		}
	}
}

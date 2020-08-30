using FileTime.DAO;
using System;
using System.Threading.Tasks;

namespace FileTime.IDAL
{
	public interface IFilerDAL
	{
		Task<Filer> GetAndUpdateFiler(string emailAddress, string efmFilerId, string password);
	}
}

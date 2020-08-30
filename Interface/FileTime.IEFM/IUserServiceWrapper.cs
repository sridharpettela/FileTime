using FileTime.DAO.EFM;
using System;
using System.Threading.Tasks;

namespace FileTime.IEFM
{
	public interface IUserServiceWrapper
	{
		Task<FilerLogin> Login(FilerLogin request);
	}
}

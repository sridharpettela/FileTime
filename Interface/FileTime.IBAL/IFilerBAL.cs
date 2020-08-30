using FileTime.DAO;
using System;
using System.Threading.Tasks;

namespace FileTime.IBAL
{
	public interface IFilerBAL
	{
		Task<Filer> Login(string emailAddress, string password);
	}
}

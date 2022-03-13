using System;
namespace GrantAccessCore.Services
{
	public class SAService
	{
		readonly DBContextPg _context;

		public SAService(DBContextPg context)
		{
			_context = context;
		}


	}
}


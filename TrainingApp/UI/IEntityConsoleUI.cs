using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUILayer.UI
{
	public interface IEntityConsoleUI<T>
		where T : class
	{
		public void ShowEntity(T entity);

		public void EntityInitialize(T entity);
	}
}

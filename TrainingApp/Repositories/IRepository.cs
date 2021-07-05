using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp.Repositories
{
	public interface IRepository<T>
		where T : class
	{
		IEnumerable<T> GetObjectList();
		T GetObject(Guid id);
		void Create(T item);
		void Update(T item);
		void Delete(Guid id);
	}
}

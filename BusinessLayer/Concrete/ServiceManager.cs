using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ServiceManager: IServiceService
	{
		IServiceDal _servicceDal;

		public ServiceManager(IServiceDal servicceDal)
		{
			_servicceDal = servicceDal;
		}

		public void TAdd(Service t)
		{
			_servicceDal.Insert(t);
		}

		public void TDelete(Service t)
		{
			_servicceDal.Delete(t);
		}

		public Service TGetByID(int id)
		{
			return _servicceDal.GetByID(id);
		}

		public List<Service> TGetList()
		{
			return _servicceDal.GetList();
		}

		public void TUpdate(Service t)
		{
			_servicceDal.Update(t);
		}
	}
}

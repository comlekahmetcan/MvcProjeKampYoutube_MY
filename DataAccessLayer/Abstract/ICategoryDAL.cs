using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDAL : IRepository<Category>
    {

    }



    //YANLIŞ KULLANIM
    //public interface ICategoryDAL
    //{
    //    //CRUD
    //    //Type Name();
    //    List<Category> List();

    //    void Insert(Category p);//Category sınıfından p  parametresi
    //    void Update(Category p);
    //    void Delete(Category p);
    //}
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı gelecek
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

        ICategoryDAL _categoryDAL;


        public List<Category> GetList()
        {
            return 
        }
    }
}

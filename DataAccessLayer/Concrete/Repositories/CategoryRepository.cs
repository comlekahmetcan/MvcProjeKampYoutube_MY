//using DataAccessLayer.Abstract;
//using EntityLayer.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccessLayer.Concrete.Repositories
//{
//    public class CategoryRepository : ICategoryDAL//YANLIŞ BİR KULLANIM SÜREKLİ YENİ METHOD GELİNCE VE HER İŞLEM YAPILACAĞI ZAMAN KOD TEKRARI OLUŞTURUYOR
//    {
//        Context c = new Context();
//        DbSet<Category> _object;
//        public void Delete(Category p)
//        {
//            _object.Remove(p);
//            c.SaveChanges();
//        }

//        public void Insert(Category p)
//        {
//            _object.Add(p);
//            c.SaveChanges();//DEĞİŞİKLER VERİ TABANINA KAYIT EDİLEBİLMESİ İÇİN
//        }

//        public List<Category> List()
//        {
//            return _object.ToList();
//        }

//        public List<Category> List(Expression<Func<Category, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Category p)
//        {
//            c.SaveChanges();
//        }
//    }
//}
///*
//    ToList
//    Add
//    Remove
//    Find

//*/
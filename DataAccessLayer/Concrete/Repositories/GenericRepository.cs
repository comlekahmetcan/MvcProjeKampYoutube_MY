using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class//bileşenlerin tamamını kapsıyor-bütün sınıflarımdan bütün interfacelerde geçerli mimari kuruldu
    {

        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();//dışarıdan gönderilen T değeri entity değerini alacak
        }
        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);//bir dizi veya listelede tek bir değer geri gönderme komutu
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);//Entry giriş
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();//filterden gönderilen değeri listele
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}

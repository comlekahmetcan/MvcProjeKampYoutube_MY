using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>//Databaseden hangi tabloyu gönderiyorsan o ( T Değeridir)
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        T Get(Expression<Func<T, bool>> filter);//id=5 olan yazar dediğimiz için get methodu
        List<T> List(Expression<Func<T, bool>> filter);//ŞARTLI LİSTELEME METHODLARI--Komple liste geri dönecek

        //Önce Repositoryde T GET gibi tanımlıyoruz sonra genericrepositoryde fonk. dolduruyoruz, oradan categoryservicede tanımlıyoruz getbyid
        //oradan categorymanager eklediğimiz getbyid methodunu tanımlyıoruz
    }
}

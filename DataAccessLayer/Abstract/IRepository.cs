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

        //1.işlem - Repositoryde T GET gibi tanımlıyoruz 
        //2.İşlem - genericrepositoryde fonk. dolduruyoruz, 
        //3.İşlem - categoryservicede tanımlıyoruz getbyid
        //4.İşlem - categorymanager eklediğimiz getbyid methodunu tanımlyıoruz
        //5.İşlem - admincategorycontroller delete actionresult oluşturduk
        //6.İşlem - index <td><a href="/AdminCategory/DeleteCategory/@item.CategoryID" class="btn btn-danger">Sil</a></td> bu kodu tanımladık
        //7.İşlem - ıcategoryservice gidip void CategoryDelete(Category category); tanımladık
        //8.İşlem - categorymanager categorydelete fonksiyonnu dolduruyoruz
        //9.İşlem - admincategorycontrollere gidip fonksiyona cm.CategoryDelete(categoryvalue); ekledik
    }
}

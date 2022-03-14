using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content//içerik
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //ContentYazar
        //ContentBaşlık

        /*başlık içerik ilişkisi*/
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        /*içeriği yazan yazar ilişkisi*/
        public int? WriterID { get; set; }//null type boş olabilir
        public virtual Writer Writer { get; set; }
    }
}

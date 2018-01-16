using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class GDDB
   {
      /// <summary>
      /// ID
      /// <summary>
      public virtual Guid ID { get; set; }
     /// <summary>
     /// 标识码
     /// <summary>
     public virtual string BSM{ get; set; }
     /// <summary>
     /// 要素代码
     /// <summary>
     public virtual string YSDM{ get; set; }
     /// <summary>
     /// 县级行政区划代码
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// 等别图斑编号
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// 等别图斑面积
     /// <summary>
     public virtual float TBMJ{ get; set; }
     /// <summary>
     /// 自然等指数
     /// <summary>
     public virtual int ZRDZS{ get; set; }
     /// <summary>
     /// 自然等
     /// <summary>
     public virtual int ZRD{ get; set; }
     /// <summary>
     /// 经济等指数
     /// <summary>
     public virtual int JJDZS{ get; set; }
     /// <summary>
     /// 经济等
     /// <summary>
     public virtual int JJD{ get; set; }
     /// <summary>
     /// 利用等指数
     /// <summary>
     public virtual int LYDZS{ get; set; }
     /// <summary>
     /// 利用等
     /// <summary>
     public virtual int LYD{ get; set; }
     /// <summary>
     /// 国家自然等指数
     /// <summary>
     public virtual int GJZRDZS{ get; set; }
     /// <summary>
     /// 国家自然等
     /// <summary>
     public virtual int GJZRD{ get; set; }
     /// <summary>
     /// 国家经济等指数
     /// <summary>
     public virtual int GJJJDZS{ get; set; }
     /// <summary>
     /// 国家经济等
     /// <summary>
     public virtual int GJJJD{ get; set; }
     /// <summary>
     /// 国家利用等指数
     /// <summary>
     public virtual int GJLYDZS{ get; set; }
     /// <summary>
     /// 国家利用等
     /// <summary>
     public virtual int GJLYD{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

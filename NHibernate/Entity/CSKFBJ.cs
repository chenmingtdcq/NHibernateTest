using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class CSKFBJ
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
     /// 城市名称
     /// <summary>
     public virtual string CSMC{ get; set; }
     /// <summary>
     /// 县级行政区划代码
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// 城市开发面积
     /// <summary>
     public virtual float CSKFMJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

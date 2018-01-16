using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class XZQJX
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
     /// 界线类型
     /// <summary>
     public virtual string JXLX{ get; set; }
     /// <summary>
     /// 界线性质
     /// <summary>
     public virtual string JXXZ{ get; set; }
     /// <summary>
     /// 界线说明
     /// <summary>
     public virtual string JXSM{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

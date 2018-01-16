using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZRYCBHQ
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
     /// 保护区名称
     /// <summary>
     public virtual string BHQMC{ get; set; }
     /// <summary>
     /// 保护区地理位置
     /// <summary>
     public virtual string BHQDLWZ{ get; set; }
     /// <summary>
     /// 保护区类型代码
     /// <summary>
     public virtual string BHQLXDM{ get; set; }
     /// <summary>
     /// 保护区级别
     /// <summary>
     public virtual string BHQJB{ get; set; }
     /// <summary>
     /// 批准机关
     /// <summary>
     public virtual string PZJG{ get; set; }
     /// <summary>
     /// 批准时间
     /// <summary>
     public virtual DateTime PZSJ{ get; set; }
     /// <summary>
     /// 保护区面积
     /// <summary>
     public virtual float BHQMJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

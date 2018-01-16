using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class SGSJ
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
     /// 数据文件名
     /// <summary>
     public virtual string SJWJM{ get; set; }
     /// <summary>
     /// 头文件名
     /// <summary>
     public virtual string TWJM{ get; set; }
     /// <summary>
     /// 元数据文件名
     /// <summary>
     public virtual string YSJWJM{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

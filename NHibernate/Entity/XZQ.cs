using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class XZQ
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
     /// 行政区代码
     /// <summary>
     public virtual string XZQDM{ get; set; }
     /// <summary>
     /// 行政区名称
     /// <summary>
     public virtual string XZQMC{ get; set; }
     /// <summary>
     /// 控制面积
     /// <summary>
     public virtual float KZMJ{ get; set; }
     /// <summary>
     /// 计算面积
     /// <summary>
     public virtual float JSMJ{ get; set; }
     /// <summary>
     /// 描述说明
     /// <summary>
     public virtual string MSSM{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

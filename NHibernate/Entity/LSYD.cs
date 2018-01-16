using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class LSYD
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
     /// 关联图斑标识码
     /// <summary>
     public virtual string GLTBBSM{ get; set; }
     /// <summary>
     /// 批准文件名称
     /// <summary>
     public virtual string PZWJMC{ get; set; }
     /// <summary>
     /// 批准文号
     /// <summary>
     public virtual string PZWH{ get; set; }
     /// <summary>
     /// 用地面积
     /// <summary>
     public virtual float LSYDMJ{ get; set; }
     /// <summary>
     /// 批准面积
     /// <summary>
     public virtual float PZMJ{ get; set; }
     /// <summary>
     /// 用地类型
     /// <summary>
     public virtual string YDLX{ get; set; }
     /// <summary>
     /// 用地用途
     /// <summary>
     public virtual string YDYT{ get; set; }
     /// <summary>
     /// 批准日期
     /// <summary>
     public virtual DateTime PZRQ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

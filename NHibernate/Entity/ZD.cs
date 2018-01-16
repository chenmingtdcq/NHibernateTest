using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZD
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
     /// 宗地代码
     /// <summary>
     public virtual string ZDDM{ get; set; }
     /// <summary>
     /// 宗地四至
     /// <summary>
     public virtual string ZDSZ{ get; set; }
     /// <summary>
     /// 座落单位代码
     /// <summary>
     public virtual string ZLDWDM{ get; set; }
     /// <summary>
     /// 权利类型
     /// <summary>
     public virtual string QLLX{ get; set; }
     /// <summary>
     /// 权利性质
     /// <summary>
     public virtual string QLXZ{ get; set; }
     /// <summary>
     /// 土地用途
     /// <summary>
     public virtual string TDYT{ get; set; }
     /// <summary>
     /// 实测面积
     /// <summary>
     public virtual float SCMJ{ get; set; }
     /// <summary>
     /// 发证面积
     /// <summary>
     public virtual float FZMJ{ get; set; }
     /// <summary>
     /// 不动产单元号
     /// <summary>
     public virtual string BDCDYH{ get; set; }
     /// <summary>
     /// 登记日期
     /// <summary>
     public virtual DateTime DJRQ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

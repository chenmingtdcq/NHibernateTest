using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZD_QLR
   {
      /// <summary>
      /// ID
      /// <summary>
      public virtual Guid ID { get; set; }
     /// <summary>
     /// 宗地标识码
     /// <summary>
     public virtual string ZDBSM{ get; set; }
     /// <summary>
     /// 宗地代码
     /// <summary>
     public virtual string ZDDM{ get; set; }
     /// <summary>
     /// 权属单位代码
     /// <summary>
     public virtual string QSDWDM{ get; set; }
     /// <summary>
     /// 权利人名称
     /// <summary>
     public virtual string QLRMC{ get; set; }
     /// <summary>
     /// 代理人姓名
     /// <summary>
     public virtual string DLRXM{ get; set; }
     /// <summary>
     /// 代理人身份证件类型
     /// <summary>
     public virtual string DLRSFZJLX{ get; set; }
     /// <summary>
     /// 代理人身份证件号
     /// <summary>
     public virtual string DLRSFZJH{ get; set; }
     /// <summary>
     /// 代理人身份证明书
     /// <summary>
     public virtual string DLRSFZMS{ get; set; }
     /// <summary>
     /// 代理人电话号码
     /// <summary>
     public virtual string DLRDH{ get; set; }
     /// <summary>
     /// 不动产权证号
     /// <summary>
     public virtual string BDCQZH{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class JZX
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
     /// 界址线长度
     /// <summary>
     public virtual float JZXCD{ get; set; }
     /// <summary>
     /// 界线性质
     /// <summary>
     public virtual string JXXZ{ get; set; }
     /// <summary>
     /// 界址线类别
     /// <summary>
     public virtual string JZXLB{ get; set; }
     /// <summary>
     /// 界址线位置
     /// <summary>
     public virtual string JZXWZ{ get; set; }
     /// <summary>
     /// 权属界线协议书编号
     /// <summary>
     public virtual string QSJXXYSBH{ get; set; }
     /// <summary>
     /// 权属界线协议书
     /// <summary>
     public virtual string QSJXXYS{ get; set; }
     /// <summary>
     /// 权属争议原由书编号
     /// <summary>
     public virtual string QSZYYYSBH{ get; set; }
     /// <summary>
     /// 权属争议原由书
     /// <summary>
     public virtual string QSZYYYS{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

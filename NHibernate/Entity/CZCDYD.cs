using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class CZCDYD
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
     /// 城镇村等用地类型
     /// <summary>
     public virtual string CZCLX{ get; set; }
     /// <summary>
     /// 城镇村代码
     /// <summary>
     public virtual string CZCDM{ get; set; }
     /// <summary>
     /// 城镇村名称
     /// <summary>
     public virtual string CZCMC{ get; set; }
     /// <summary>
     /// 城镇村面积
     /// <summary>
     public virtual float CZCMJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

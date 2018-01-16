using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZYXMYD
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
     /// 项目名称
     /// <summary>
     public virtual string XMMC{ get; set; }
     /// <summary>
     /// 项目类型
     /// <summary>
     public virtual string XMLX{ get; set; }
     /// <summary>
     /// 项目规模
     /// <summary>
     public virtual string XMGM{ get; set; }
     /// <summary>
     /// 占地面积
     /// <summary>
     public virtual float ZDMJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

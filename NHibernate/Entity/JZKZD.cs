using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class JZKZD
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
     /// 控制点名称
     /// <summary>
     public virtual string KZDMC{ get; set; }
     /// <summary>
     /// 控制点点号
     /// <summary>
     public virtual string KZDDH{ get; set; }
     /// <summary>
     /// 控制点类型
     /// <summary>
     public virtual string KZDLX{ get; set; }
     /// <summary>
     /// 控制点等级
     /// <summary>
     public virtual string KZDDJ{ get; set; }
     /// <summary>
     /// 点之记
     /// <summary>
     public virtual string DZJ{ get; set; }
     /// <summary>
     /// 点位DOM影像
     /// <summary>
     public virtual string DWYX{ get; set; }
     /// <summary>
     /// 点位实地照片
     /// <summary>
     public virtual string DWZP{ get; set; }
     /// <summary>
     /// X坐标
     /// <summary>
     public virtual float XZB{ get; set; }
     /// <summary>
     /// Y坐标
     /// <summary>
     public virtual float YZB{ get; set; }
     /// <summary>
     /// Z坐标
     /// <summary>
     public virtual float ZZB{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

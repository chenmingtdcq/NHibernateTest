using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class SZZSYX
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
     /// 图幅编号
     /// <summary>
     public virtual string TFBH{ get; set; }
     /// <summary>
     /// 图幅名称
     /// <summary>
     public virtual string TFMC{ get; set; }
     /// <summary>
     /// 影像来源
     /// <summary>
     public virtual string YXLY{ get; set; }
     /// <summary>
     /// 影像分辨率
     /// <summary>
     public virtual string KZDDJ{ get; set; }
     /// <summary>
     /// 成图比例尺
     /// <summary>
     public virtual string CTBLC{ get; set; }
     /// <summary>
     /// 坐标系统类型
     /// <summary>
     public virtual string ZBCKX{ get; set; }
     /// <summary>
     /// 大地平面投影坐标
     /// <summary>
     public virtual string DDPMZBTY{ get; set; }
     /// <summary>
     /// 中央子午线经度
     /// <summary>
     public virtual float ZYZWXJD{ get; set; }
     /// <summary>
     /// 左下角X坐标
     /// <summary>
     public virtual float ZXJXZB{ get; set; }
     /// <summary>
     /// 左下角Y坐标
     /// <summary>
     public virtual float ZXJYZB{ get; set; }
     /// <summary>
     /// 右上角X坐标
     /// <summary>
     public virtual float YSJXZB{ get; set; }
     /// <summary>
     /// 右上角Y坐标
     /// <summary>
     public virtual float YSJYZB{ get; set; }
     /// <summary>
     /// 拍摄时间
     /// <summary>
     public virtual DateTime PSSJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

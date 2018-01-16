using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZJ
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
     /// 注记内容
     /// <summary>
     public virtual string ZJNR{ get; set; }
     /// <summary>
     /// 字体
     /// <summary>
     public virtual string ZT{ get; set; }
     /// <summary>
     /// 颜色
     /// <summary>
     public virtual string YS{ get; set; }
     /// <summary>
     /// 磅数
     /// <summary>
     public virtual int BS{ get; set; }
     /// <summary>
     /// 形状
     /// <summary>
     public virtual string XZ{ get; set; }
     /// <summary>
     /// 下划线
     /// <summary>
     public virtual string XHX{ get; set; }
     /// <summary>
     /// 宽度
     /// <summary>
     public virtual float KD{ get; set; }
     /// <summary>
     /// 高度
     /// <summary>
     public virtual float GD{ get; set; }
     /// <summary>
     /// 间隔
     /// <summary>
     public virtual float JG{ get; set; }
     /// <summary>
     /// 注记点左下角X坐标
     /// <summary>
     public virtual float ZJDZXJXZB{ get; set; }
     /// <summary>
     /// 注记点左下角Y坐标
     /// <summary>
     public virtual float ZJDZXJYZB{ get; set; }
     /// <summary>
     /// 注记方向
     /// <summary>
     public virtual float ZJFX{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

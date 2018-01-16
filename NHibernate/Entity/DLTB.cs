using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class DLTB
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
     /// 图斑预编号
     /// <summary>
     public virtual string TBYBH{ get; set; }
     /// <summary>
     /// 图斑编号
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// 地类编码
     /// <summary>
     public virtual string DLBM{ get; set; }
     /// <summary>
     /// 地类名称
     /// <summary>
     public virtual string DLMC{ get; set; }
     /// <summary>
     /// 权属性质
     /// <summary>
     public virtual string QSXZ{ get; set; }
     /// <summary>
     /// 权属单位代码
     /// <summary>
     public virtual string QSDWDM{ get; set; }
     /// <summary>
     /// 权属单位名称
     /// <summary>
     public virtual string QSDWMC{ get; set; }
     /// <summary>
     /// 座落单位代码
     /// <summary>
     public virtual string ZLDWDM{ get; set; }
     /// <summary>
     /// 座落单位名称
     /// <summary>
     public virtual string ZLDWMC{ get; set; }
     /// <summary>
     /// 图斑面积
     /// <summary>
     public virtual float TBMJ{ get; set; }
     /// <summary>
     /// 扣除地类编码
     /// <summary>
     public virtual string KCDLBM{ get; set; }
     /// <summary>
     /// 扣除地类系数
     /// <summary>
     public virtual float TKXS{ get; set; }
     /// <summary>
     /// 扣除地类面积
     /// <summary>
     public virtual float TKMJ{ get; set; }
     /// <summary>
     /// 图斑地类面积
     /// <summary>
     public virtual float TBDLMJ{ get; set; }
     /// <summary>
     /// 耕地类型
     /// <summary>
     public virtual string GDLX{ get; set; }
     /// <summary>
     /// 耕地坡度级别
     /// <summary>
     public virtual string GDPDJB{ get; set; }
     /// <summary>
     /// 线性图斑宽度
     /// <summary>
     public virtual float XXTBKD{ get; set; }
     /// <summary>
     /// 图斑细化代码
     /// <summary>
     public virtual string TBXHDM{ get; set; }
     /// <summary>
     /// 图斑细化名称
     /// <summary>
     public virtual string TBXHMC{ get; set; }
     /// <summary>
     /// 耕地种植属性代码
     /// <summary>
     public virtual string GDZZSXDM{ get; set; }
     /// <summary>
     /// 耕地种植属性名称
     /// <summary>
     public virtual string GDZZSXMC{ get; set; }
     /// <summary>
     /// 耕地等别
     /// <summary>
     public virtual string GDDB{ get; set; }
     /// <summary>
     /// 飞入地标识
     /// <summary>
     public virtual string FRDBS{ get; set; }
     /// <summary>
     /// 城镇村属性码
     /// <summary>
     public virtual string CZCSXM{ get; set; }
     /// <summary>
     /// 数据年份
     /// <summary>
     public virtual int SJNF{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

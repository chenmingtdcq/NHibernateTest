using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class PZWJSTD
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
     /// 图斑编号
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// 县级行政区划代码
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// 县级行政区划名称
     /// <summary>
     public virtual string XJXZQHMC{ get; set; }
     /// <summary>
     /// 项目编号
     /// <summary>
     public virtual string BZXMBH{ get; set; }
     /// <summary>
     /// 项目名称
     /// <summary>
     public virtual string BZXMMC{ get; set; }
     /// <summary>
     /// 批准文号
     /// <summary>
     public virtual string BZPZWH{ get; set; }
     /// <summary>
     /// 批准日期
     /// <summary>
     public virtual DateTime BZPZRQ{ get; set; }
     /// <summary>
     /// 项目类型
     /// <summary>
     public virtual string PZXMLX{ get; set; }
     /// <summary>
     /// 批准用途
     /// <summary>
     public virtual string PZYT{ get; set; }
     /// <summary>
     /// 批准面积
     /// <summary>
     public virtual float PZMJ{ get; set; }
     /// <summary>
     /// 图斑面积
     /// <summary>
     public virtual float BZTBMJ{ get; set; }
     /// <summary>
     /// 新增建设用地面积
     /// <summary>
     public virtual float BZXZJSYDMJ{ get; set; }
     /// <summary>
     /// 占用耕地面积
     /// <summary>
     public virtual float BZZYGDMJ{ get; set; }
     /// <summary>
     /// 备注
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

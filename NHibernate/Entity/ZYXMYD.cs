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
     /// ��ʶ��
     /// <summary>
     public virtual string BSM{ get; set; }
     /// <summary>
     /// Ҫ�ش���
     /// <summary>
     public virtual string YSDM{ get; set; }
     /// <summary>
     /// ��Ŀ����
     /// <summary>
     public virtual string XMMC{ get; set; }
     /// <summary>
     /// ��Ŀ����
     /// <summary>
     public virtual string XMLX{ get; set; }
     /// <summary>
     /// ��Ŀ��ģ
     /// <summary>
     public virtual string XMGM{ get; set; }
     /// <summary>
     /// ռ�����
     /// <summary>
     public virtual float ZDMJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

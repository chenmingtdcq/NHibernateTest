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
     /// ��ʶ��
     /// <summary>
     public virtual string BSM{ get; set; }
     /// <summary>
     /// Ҫ�ش���
     /// <summary>
     public virtual string YSDM{ get; set; }
     /// <summary>
     /// ���Ƶ�����
     /// <summary>
     public virtual string KZDMC{ get; set; }
     /// <summary>
     /// ���Ƶ���
     /// <summary>
     public virtual string KZDDH{ get; set; }
     /// <summary>
     /// ���Ƶ�����
     /// <summary>
     public virtual string KZDLX{ get; set; }
     /// <summary>
     /// ���Ƶ�ȼ�
     /// <summary>
     public virtual string KZDDJ{ get; set; }
     /// <summary>
     /// ��֮��
     /// <summary>
     public virtual string DZJ{ get; set; }
     /// <summary>
     /// ��λDOMӰ��
     /// <summary>
     public virtual string DWYX{ get; set; }
     /// <summary>
     /// ��λʵ����Ƭ
     /// <summary>
     public virtual string DWZP{ get; set; }
     /// <summary>
     /// X����
     /// <summary>
     public virtual float XZB{ get; set; }
     /// <summary>
     /// Y����
     /// <summary>
     public virtual float YZB{ get; set; }
     /// <summary>
     /// Z����
     /// <summary>
     public virtual float ZZB{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

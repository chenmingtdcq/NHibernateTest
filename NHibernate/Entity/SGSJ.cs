using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class SGSJ
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
     /// �����ļ���
     /// <summary>
     public virtual string SJWJM{ get; set; }
     /// <summary>
     /// ͷ�ļ���
     /// <summary>
     public virtual string TWJM{ get; set; }
     /// <summary>
     /// Ԫ�����ļ���
     /// <summary>
     public virtual string YSJWJM{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

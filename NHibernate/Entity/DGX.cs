using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class DGX
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
     /// �ȸ�������
     /// <summary>
     public virtual string DGXLX{ get; set; }
     /// <summary>
     /// ��ʾ�߳�
     /// <summary>
     public virtual int BSGC{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

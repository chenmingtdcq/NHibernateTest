using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZRYCBHQ
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
     /// ����������
     /// <summary>
     public virtual string BHQMC{ get; set; }
     /// <summary>
     /// ����������λ��
     /// <summary>
     public virtual string BHQDLWZ{ get; set; }
     /// <summary>
     /// ���������ʹ���
     /// <summary>
     public virtual string BHQLXDM{ get; set; }
     /// <summary>
     /// ����������
     /// <summary>
     public virtual string BHQJB{ get; set; }
     /// <summary>
     /// ��׼����
     /// <summary>
     public virtual string PZJG{ get; set; }
     /// <summary>
     /// ��׼ʱ��
     /// <summary>
     public virtual DateTime PZSJ{ get; set; }
     /// <summary>
     /// ���������
     /// <summary>
     public virtual float BHQMJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

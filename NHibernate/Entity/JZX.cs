using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class JZX
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
     /// ��ַ�߳���
     /// <summary>
     public virtual float JZXCD{ get; set; }
     /// <summary>
     /// ��������
     /// <summary>
     public virtual string JXXZ{ get; set; }
     /// <summary>
     /// ��ַ�����
     /// <summary>
     public virtual string JZXLB{ get; set; }
     /// <summary>
     /// ��ַ��λ��
     /// <summary>
     public virtual string JZXWZ{ get; set; }
     /// <summary>
     /// Ȩ������Э������
     /// <summary>
     public virtual string QSJXXYSBH{ get; set; }
     /// <summary>
     /// Ȩ������Э����
     /// <summary>
     public virtual string QSJXXYS{ get; set; }
     /// <summary>
     /// Ȩ������ԭ������
     /// <summary>
     public virtual string QSZYYYSBH{ get; set; }
     /// <summary>
     /// Ȩ������ԭ����
     /// <summary>
     public virtual string QSZYYYS{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZD
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
     /// �ڵش���
     /// <summary>
     public virtual string ZDDM{ get; set; }
     /// <summary>
     /// �ڵ�����
     /// <summary>
     public virtual string ZDSZ{ get; set; }
     /// <summary>
     /// ���䵥λ����
     /// <summary>
     public virtual string ZLDWDM{ get; set; }
     /// <summary>
     /// Ȩ������
     /// <summary>
     public virtual string QLLX{ get; set; }
     /// <summary>
     /// Ȩ������
     /// <summary>
     public virtual string QLXZ{ get; set; }
     /// <summary>
     /// ������;
     /// <summary>
     public virtual string TDYT{ get; set; }
     /// <summary>
     /// ʵ�����
     /// <summary>
     public virtual float SCMJ{ get; set; }
     /// <summary>
     /// ��֤���
     /// <summary>
     public virtual float FZMJ{ get; set; }
     /// <summary>
     /// ��������Ԫ��
     /// <summary>
     public virtual string BDCDYH{ get; set; }
     /// <summary>
     /// �Ǽ�����
     /// <summary>
     public virtual DateTime DJRQ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

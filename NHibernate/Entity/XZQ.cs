using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class XZQ
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
     public virtual string XZQDM{ get; set; }
     /// <summary>
     /// ����������
     /// <summary>
     public virtual string XZQMC{ get; set; }
     /// <summary>
     /// �������
     /// <summary>
     public virtual float KZMJ{ get; set; }
     /// <summary>
     /// �������
     /// <summary>
     public virtual float JSMJ{ get; set; }
     /// <summary>
     /// ����˵��
     /// <summary>
     public virtual string MSSM{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

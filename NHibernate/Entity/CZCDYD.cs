using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class CZCDYD
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
     /// �������õ�����
     /// <summary>
     public virtual string CZCLX{ get; set; }
     /// <summary>
     /// ��������
     /// <summary>
     public virtual string CZCDM{ get; set; }
     /// <summary>
     /// ���������
     /// <summary>
     public virtual string CZCMC{ get; set; }
     /// <summary>
     /// ��������
     /// <summary>
     public virtual float CZCMJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

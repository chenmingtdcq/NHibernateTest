using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class CSKFBJ
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
     /// ��������
     /// <summary>
     public virtual string CSMC{ get; set; }
     /// <summary>
     /// �ؼ�������������
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// ���п������
     /// <summary>
     public virtual float CSKFMJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class LSYD
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
     /// ����ͼ�߱�ʶ��
     /// <summary>
     public virtual string GLTBBSM{ get; set; }
     /// <summary>
     /// ��׼�ļ�����
     /// <summary>
     public virtual string PZWJMC{ get; set; }
     /// <summary>
     /// ��׼�ĺ�
     /// <summary>
     public virtual string PZWH{ get; set; }
     /// <summary>
     /// �õ����
     /// <summary>
     public virtual float LSYDMJ{ get; set; }
     /// <summary>
     /// ��׼���
     /// <summary>
     public virtual float PZMJ{ get; set; }
     /// <summary>
     /// �õ�����
     /// <summary>
     public virtual string YDLX{ get; set; }
     /// <summary>
     /// �õ���;
     /// <summary>
     public virtual string YDYT{ get; set; }
     /// <summary>
     /// ��׼����
     /// <summary>
     public virtual DateTime PZRQ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

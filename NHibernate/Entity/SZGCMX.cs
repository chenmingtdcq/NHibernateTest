using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class SZGCMX
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
     /// ͼ�����
     /// <summary>
     public virtual string TFBH{ get; set; }
     /// <summary>
     /// ͼ������
     /// <summary>
     public virtual string TFMC{ get; set; }
     /// <summary>
     /// �����ߴ�
     /// <summary>
     public virtual float GWCC{ get; set; }
     /// <summary>
     /// ��ͼ������
     /// <summary>
     public virtual string CTBLC{ get; set; }
     /// <summary>
     /// ����ϵͳ����
     /// <summary>
     public virtual string ZBCKX{ get; set; }
     /// <summary>
     /// ���ƽ��ͶӰ����
     /// <summary>
     public virtual string DDPMZBTY{ get; set; }
     /// <summary>
     /// ���������߾���
     /// <summary>
     public virtual float ZYZWXJD{ get; set; }
     /// <summary>
     /// ���½�X����
     /// <summary>
     public virtual float ZXJXZB{ get; set; }
     /// <summary>
     /// ���½�Y����
     /// <summary>
     public virtual float ZXJYZB{ get; set; }
     /// <summary>
     /// ���Ͻ�X����
     /// <summary>
     public virtual float YSJXZB{ get; set; }
     /// <summary>
     /// ���Ͻ�Y����
     /// <summary>
     public virtual float YSJYZB{ get; set; }
     /// <summary>
     /// ����ʱ��
     /// <summary>
     public virtual DateTime ZZSJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

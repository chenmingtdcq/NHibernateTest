using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class PZWJSTD
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
     /// ͼ�߱��
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// �ؼ�������������
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// �ؼ�������������
     /// <summary>
     public virtual string XJXZQHMC{ get; set; }
     /// <summary>
     /// ��Ŀ���
     /// <summary>
     public virtual string BZXMBH{ get; set; }
     /// <summary>
     /// ��Ŀ����
     /// <summary>
     public virtual string BZXMMC{ get; set; }
     /// <summary>
     /// ��׼�ĺ�
     /// <summary>
     public virtual string BZPZWH{ get; set; }
     /// <summary>
     /// ��׼����
     /// <summary>
     public virtual DateTime BZPZRQ{ get; set; }
     /// <summary>
     /// ��Ŀ����
     /// <summary>
     public virtual string PZXMLX{ get; set; }
     /// <summary>
     /// ��׼��;
     /// <summary>
     public virtual string PZYT{ get; set; }
     /// <summary>
     /// ��׼���
     /// <summary>
     public virtual float PZMJ{ get; set; }
     /// <summary>
     /// ͼ�����
     /// <summary>
     public virtual float BZTBMJ{ get; set; }
     /// <summary>
     /// ���������õ����
     /// <summary>
     public virtual float BZXZJSYDMJ{ get; set; }
     /// <summary>
     /// ռ�ø������
     /// <summary>
     public virtual float BZZYGDMJ{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class GDDB
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
     /// �ؼ�������������
     /// <summary>
     public virtual string XJXZQHDM{ get; set; }
     /// <summary>
     /// �ȱ�ͼ�߱��
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// �ȱ�ͼ�����
     /// <summary>
     public virtual float TBMJ{ get; set; }
     /// <summary>
     /// ��Ȼ��ָ��
     /// <summary>
     public virtual int ZRDZS{ get; set; }
     /// <summary>
     /// ��Ȼ��
     /// <summary>
     public virtual int ZRD{ get; set; }
     /// <summary>
     /// ���õ�ָ��
     /// <summary>
     public virtual int JJDZS{ get; set; }
     /// <summary>
     /// ���õ�
     /// <summary>
     public virtual int JJD{ get; set; }
     /// <summary>
     /// ���õ�ָ��
     /// <summary>
     public virtual int LYDZS{ get; set; }
     /// <summary>
     /// ���õ�
     /// <summary>
     public virtual int LYD{ get; set; }
     /// <summary>
     /// ������Ȼ��ָ��
     /// <summary>
     public virtual int GJZRDZS{ get; set; }
     /// <summary>
     /// ������Ȼ��
     /// <summary>
     public virtual int GJZRD{ get; set; }
     /// <summary>
     /// ���Ҿ��õ�ָ��
     /// <summary>
     public virtual int GJJJDZS{ get; set; }
     /// <summary>
     /// ���Ҿ��õ�
     /// <summary>
     public virtual int GJJJD{ get; set; }
     /// <summary>
     /// �������õ�ָ��
     /// <summary>
     public virtual int GJLYDZS{ get; set; }
     /// <summary>
     /// �������õ�
     /// <summary>
     public virtual int GJLYD{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

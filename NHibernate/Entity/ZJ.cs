using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZJ
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
     /// ע������
     /// <summary>
     public virtual string ZJNR{ get; set; }
     /// <summary>
     /// ����
     /// <summary>
     public virtual string ZT{ get; set; }
     /// <summary>
     /// ��ɫ
     /// <summary>
     public virtual string YS{ get; set; }
     /// <summary>
     /// ����
     /// <summary>
     public virtual int BS{ get; set; }
     /// <summary>
     /// ��״
     /// <summary>
     public virtual string XZ{ get; set; }
     /// <summary>
     /// �»���
     /// <summary>
     public virtual string XHX{ get; set; }
     /// <summary>
     /// ���
     /// <summary>
     public virtual float KD{ get; set; }
     /// <summary>
     /// �߶�
     /// <summary>
     public virtual float GD{ get; set; }
     /// <summary>
     /// ���
     /// <summary>
     public virtual float JG{ get; set; }
     /// <summary>
     /// ע�ǵ����½�X����
     /// <summary>
     public virtual float ZJDZXJXZB{ get; set; }
     /// <summary>
     /// ע�ǵ����½�Y����
     /// <summary>
     public virtual float ZJDZXJYZB{ get; set; }
     /// <summary>
     /// ע�Ƿ���
     /// <summary>
     public virtual float ZJFX{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

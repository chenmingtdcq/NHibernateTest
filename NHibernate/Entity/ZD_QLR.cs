using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class ZD_QLR
   {
      /// <summary>
      /// ID
      /// <summary>
      public virtual Guid ID { get; set; }
     /// <summary>
     /// �ڵر�ʶ��
     /// <summary>
     public virtual string ZDBSM{ get; set; }
     /// <summary>
     /// �ڵش���
     /// <summary>
     public virtual string ZDDM{ get; set; }
     /// <summary>
     /// Ȩ����λ����
     /// <summary>
     public virtual string QSDWDM{ get; set; }
     /// <summary>
     /// Ȩ��������
     /// <summary>
     public virtual string QLRMC{ get; set; }
     /// <summary>
     /// ����������
     /// <summary>
     public virtual string DLRXM{ get; set; }
     /// <summary>
     /// ���������֤������
     /// <summary>
     public virtual string DLRSFZJLX{ get; set; }
     /// <summary>
     /// ���������֤����
     /// <summary>
     public virtual string DLRSFZJH{ get; set; }
     /// <summary>
     /// ���������֤����
     /// <summary>
     public virtual string DLRSFZMS{ get; set; }
     /// <summary>
     /// �����˵绰����
     /// <summary>
     public virtual string DLRDH{ get; set; }
     /// <summary>
     /// ������Ȩ֤��
     /// <summary>
     public virtual string BDCQZH{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

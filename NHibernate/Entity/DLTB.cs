using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHibernateORM.Entity
{
   [Serializable]
   public class DLTB
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
     /// ͼ��Ԥ���
     /// <summary>
     public virtual string TBYBH{ get; set; }
     /// <summary>
     /// ͼ�߱��
     /// <summary>
     public virtual string TBBH{ get; set; }
     /// <summary>
     /// �������
     /// <summary>
     public virtual string DLBM{ get; set; }
     /// <summary>
     /// ��������
     /// <summary>
     public virtual string DLMC{ get; set; }
     /// <summary>
     /// Ȩ������
     /// <summary>
     public virtual string QSXZ{ get; set; }
     /// <summary>
     /// Ȩ����λ����
     /// <summary>
     public virtual string QSDWDM{ get; set; }
     /// <summary>
     /// Ȩ����λ����
     /// <summary>
     public virtual string QSDWMC{ get; set; }
     /// <summary>
     /// ���䵥λ����
     /// <summary>
     public virtual string ZLDWDM{ get; set; }
     /// <summary>
     /// ���䵥λ����
     /// <summary>
     public virtual string ZLDWMC{ get; set; }
     /// <summary>
     /// ͼ�����
     /// <summary>
     public virtual float TBMJ{ get; set; }
     /// <summary>
     /// �۳��������
     /// <summary>
     public virtual string KCDLBM{ get; set; }
     /// <summary>
     /// �۳�����ϵ��
     /// <summary>
     public virtual float TKXS{ get; set; }
     /// <summary>
     /// �۳��������
     /// <summary>
     public virtual float TKMJ{ get; set; }
     /// <summary>
     /// ͼ�ߵ������
     /// <summary>
     public virtual float TBDLMJ{ get; set; }
     /// <summary>
     /// ��������
     /// <summary>
     public virtual string GDLX{ get; set; }
     /// <summary>
     /// �����¶ȼ���
     /// <summary>
     public virtual string GDPDJB{ get; set; }
     /// <summary>
     /// ����ͼ�߿��
     /// <summary>
     public virtual float XXTBKD{ get; set; }
     /// <summary>
     /// ͼ��ϸ������
     /// <summary>
     public virtual string TBXHDM{ get; set; }
     /// <summary>
     /// ͼ��ϸ������
     /// <summary>
     public virtual string TBXHMC{ get; set; }
     /// <summary>
     /// ������ֲ���Դ���
     /// <summary>
     public virtual string GDZZSXDM{ get; set; }
     /// <summary>
     /// ������ֲ��������
     /// <summary>
     public virtual string GDZZSXMC{ get; set; }
     /// <summary>
     /// ���صȱ�
     /// <summary>
     public virtual string GDDB{ get; set; }
     /// <summary>
     /// ����ر�ʶ
     /// <summary>
     public virtual string FRDBS{ get; set; }
     /// <summary>
     /// �����������
     /// <summary>
     public virtual string CZCSXM{ get; set; }
     /// <summary>
     /// �������
     /// <summary>
     public virtual int SJNF{ get; set; }
     /// <summary>
     /// ��ע
     /// <summary>
     public virtual string BZ{ get; set; }
   }
}

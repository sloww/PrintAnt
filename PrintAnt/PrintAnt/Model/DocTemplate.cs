using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAnt.Model
{
    /// <summary>
    /// 用来定义文档的外观的结构 主要是描述xml
    /// </summary>
    [Table("PADocTemplate", Schema = "dbo")]
    class DocTemplate:ICloneable
    {
        [Required]
        int ID { get; set; }
        [Required]
        Guid DocGuid { get; set; }
        [Required]
        string PinterFullName { get; set; }
        [Required]
        string DocTemplateName { get; set; }
        [Required]
        string Xml { get; set; }
        [Required]
        DateTime CreateDateTime { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

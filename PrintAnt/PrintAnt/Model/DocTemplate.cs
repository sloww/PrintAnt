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
    class DocTemplate
    {
        int ID;
        [Required]
        Guid DocGuid;
        [Required]
        string PinterFullName;
        [Required]
        string DocTemplateName;
        [Required]
        string Xml;
        [Required]
        DateTime CreateDateTime;
    }
}

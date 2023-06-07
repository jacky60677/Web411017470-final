using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web411017470.Models
{
    [MetadataType(typeof(TableMetadata))]

    public partial class Table
    {
    }

    public class TableMetadata
    {

        public int Id
        {
            get; set;
        }
        [Required(ErrorMessage = "欄位標題必須為50的字串")]
        [Display(Name = "標題")]
        [StringLength(50)]

        public string Title
        {
            get; set;
        }
        [Required(ErrorMessage = "必填項目")]
        [Display(Name = "內容")]
        public string Content
        {
            get; set;
        }
        [Required(ErrorMessage = "必填項目")]
        [Display(Name = "發布日期")]
        public System.DateTime PublishDate
        {
            get; set;
        }
    }

}
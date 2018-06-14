using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace RecrutTask.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DataModelEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TextId { get; set; }

        [Display(Name = "Enter text")]
        [Required(ErrorMessage = "Please, enter the text!")]    
        public string InputString { get; set; }

        [Display(Name = "Text translated")]
        public string TranslatedString { get; set; }
    }

}
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace puppyPlayDates.Models
{
    public class ImageModel
    {
        // public string? UserImgUrl { get; set; }
        [Display(Name = "Upload an image of your pet")]
        public IFormFile UserImg { get; set; }
    }
}

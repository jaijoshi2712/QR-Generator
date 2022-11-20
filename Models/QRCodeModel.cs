using System.ComponentModel.DataAnnotations;

namespace QR_Generator.Models
{
    public class QRCodeModel
    {

        [Display(Name = "Enter QRCode Text")]
        public string? QRCodeText { get; set; }


    }
}

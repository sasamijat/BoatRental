using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BIgGameCore.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageName { get; set; }

        public string? Attachment { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public ImageModel() { 
        }
        public ImageModel(ImageModel x) {

            ImageId = x.ImageId;
            ImageName = x.ImageName;
            ImageFile = x.ImageFile;
            Attachment = x.Attachment;
        }
    }
}

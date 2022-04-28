using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotelWorkOrderManagement.Models;
using Microsoft.AspNetCore.Http;

namespace HotelWorkOrderManagement.DTO.Comment
{
    public class CommentDataIn
    {
        public string Text { get; set; }
        public int TaskID { get; set; }
        public int CreatedById { get; set; }
        public IFormFile? CommentFile { get; set; }
        public string? CommentImage { get; set; }
        public string? ImageName { get; set; }

        public CommentDataIn() { }
        public CommentDataIn(Models.Comment comment) {
        
            Text = comment.Text;
            CreatedById = comment.CreatedById;
            TaskID = comment.TaskID;

        
        }
    }
}

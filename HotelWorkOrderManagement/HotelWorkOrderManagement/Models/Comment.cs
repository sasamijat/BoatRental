using HotelWorkOrderManagement.DTO.Comment;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HotelWorkOrderManagement.Models
{
    public class Comment : BaseEntity
    {
       
       
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public Models.Task Task { get; set; }
        public int TaskID { get; set; }
        public User CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public string? CommentImage { get; set; }

        public Comment() { }
        public Comment(CommentDataIn comment)
        {

            Text = comment.Text;
            CreatedById = comment.CreatedById;
            TaskID = comment.TaskID;


        }


    }
}

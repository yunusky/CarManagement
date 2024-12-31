﻿using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.CommentDtos
{
    public class CommentUpdateDto
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
    }
}
﻿namespace blog.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string? Image { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

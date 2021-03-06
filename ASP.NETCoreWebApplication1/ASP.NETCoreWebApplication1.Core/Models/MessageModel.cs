﻿using System;

namespace ASP.NETCoreWebApplication1.Core.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string UserId { get; set; }
        public ApplicationUser Sender { get; set; }
        public bool isMine { get; set; }
        public MessageModel()
        {
            When = DateTime.Now;
        }
    }
}

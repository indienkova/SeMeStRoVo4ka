using System;

namespace ASP.NETCoreWebApplication1.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string request { get; set; }
        public string response { get; set; }
        public Log()
        {
            TimeStamp = DateTime.Now;
        }
    }
}

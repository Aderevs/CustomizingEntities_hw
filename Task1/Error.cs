using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Error
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Request {  get; set; }
        public StatusCode Status { get; set; }

        public Error(DateTime time, StatusCode status)
        {
            Time = time;
            Status = status;
        }
        public Error(string msg, DateTime time, StatusCode status, string req) :this(time, status)
        {
            Message = msg;
            Request = req;
        } 

    }
}

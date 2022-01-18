using Amazon.Lambda.S3Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckFileUploaded
{
    public class State
    {
        public bool Status { get; set; }
        public S3Event Event { get; set; }

        public State() { }

        public State(bool status, S3Event e)
        {
            this.Status = status;
            this.Event = e;
        }
    }
}

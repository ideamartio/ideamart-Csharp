﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ideamart.Sms
{
    public class ReceiveSmsObject
    {
        public string message { get; set; }
        public string sourceAddress { get; set; }
        public string requestId { get; set; }
        public string encoding { get; set; }
        public string version { get; set; }
    }
}
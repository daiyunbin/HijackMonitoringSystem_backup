﻿using System;
using System.Collections.Generic;
using _17ceBackendFunction.BusinessLayer.Dtos.GeneralData;

namespace _17ceBackendFunction.BusinessLayer.Dtos
{
    public class HijackingDomainDto : PersistenceDtos, IPersistenceDtos
    {
		public string Protocol { get; set; }
        public string Domain { get; set; }
        public string DestinationIp { get; set; }
        public string CustomerId { get; set; }
        public int Status { get; set; }
        public DateTime ToStartTime { get; set; }
        public DateTime ToEndTime { get; set; }
        public int Interval { get; set; }
        public string Province { get; set; }
        public string Isp { get; set; }
		public string Redirection { get; set; }
        public DateTime LastExecuted { get; set; }

    }
}
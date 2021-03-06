﻿using System;
using System.Collections;
using System.Collections.Generic;
using AuditLog.Enums;

namespace AuditLog.Models
{
    public class AuditLogEntry
    {
        public DateTime StartDateOfChange { get; set; }
        public DateTime EndDateOfChange { get; set; }
        public IList<string> AffectedDays { get; set; }
        public string TypeOfChange { get; set; }
        public bool IsPlanned { get; set; } // todo additional field
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public IList<Approval> Approvals { get; set; }
    }
}

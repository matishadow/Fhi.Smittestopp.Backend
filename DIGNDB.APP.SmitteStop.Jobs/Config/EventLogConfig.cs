﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DIGNDB.APP.SmitteStop.Jobs.Config
{
    public class EventLogConfig
    {
        [Required(AllowEmptyStrings = false)]
        public string LogName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string SourceName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string MachineName { get; set; }
    }
}

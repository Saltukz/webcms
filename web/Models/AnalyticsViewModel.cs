using Google.Apis.AnalyticsReporting.v4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class AnalyticsViewModel
    {
        public List<ReportRow> AnalyticsRecords { get; internal set; }
    }
}

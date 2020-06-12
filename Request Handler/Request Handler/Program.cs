using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request_Handler
{
    class Program
    {
        static void Main(string[] args)
        {
            SELECT* FROM RMS.RequestSummaryView r
JOIN PTS.PrescriptionTrackingStatusType t ON r.PrescriptionTrackingStatusTypeId = t.PrescriptionTrackingStatusTypeId
WHERE t.Description = 'Requested'

                https://github.com/jstedfast/MailKit
        }
    }
}

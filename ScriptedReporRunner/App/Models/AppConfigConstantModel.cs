using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptedReporRunner.App.Models
{
   
    public class AppConfigConstantModel
    {
        public string app_name { get; set; }
        public List<ApplciationReportCommand> commands { get; set; }
    }

    public class ApplciationReportCommand
    {
        public string report_code { get; set; }
        public string report_name { get; set; }
        public string execution_path { get; set; }
        public string working_dir_path { get; set; }
        public string cmd_arguments { get; set; }

        public string report_readme { get; set; }

        
    }


}

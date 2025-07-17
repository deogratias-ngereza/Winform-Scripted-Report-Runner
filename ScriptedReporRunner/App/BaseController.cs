using ScriptedReporRunner.App.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptedReporRunner.App
{
    public class BaseController
    {
        public BaseController() { 
        
        }

        public string get_my_path()
        {
            try
            {
                var executing_path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                string targetDir = string.Format(executing_path + @"\");
                return targetDir;
            }
            catch (Exception ex)
            {
                Console.WriteLine("--- LOADING PATH ERROR : --- " + ex.Message);
                return "";
            }
        }
        public static string app_path()
        {
            try
            {
                var executing_path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                string targetDir = string.Format(executing_path + @"\");
                return targetDir;
            }
            catch (Exception ex)
            {
                Console.WriteLine("--- LOADING PATH ERROR : --- " + ex.Message);
                return "";
            }
        }


        public AppConfigConstantModel getAppConfigs()
        {
            try
            {
                //open the file
                using (StreamReader r = new StreamReader(get_my_path() + @"config\configs.json"))
                {
                    string json = r.ReadToEnd();
                    AppConfigConstantModel configObject = Newtonsoft.Json.JsonConvert.DeserializeObject<AppConfigConstantModel>(json);
                    return configObject;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
                return new AppConfigConstantModel();
            }
        }//

    }
}

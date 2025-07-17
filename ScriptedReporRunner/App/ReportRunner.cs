using ScriptedReporRunner.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptedReporRunner.App
{
    public partial class ReportRunner : Form
    {
        BaseController baseController;
        AppConfigConstantModel applicationConfiguration;
        ApplciationReportCommand CurrentSelectedCommand;
        public ReportRunner()
        {
            InitializeComponent();
            baseController = new BaseController();
            applicationConfiguration = baseController.getAppConfigs();
        }

        private void ReportRunner_Load(object sender, EventArgs e)
        {
            loadCommandsIntoComboBox();
        }

        private void loadCommandsIntoComboBox()
        {
            //List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
            for (var i = 0; i < applicationConfiguration.commands.Count; i++ )
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = applicationConfiguration.commands[i].report_name;
                item.Value = applicationConfiguration.commands[i].report_code;

                reportTypeComboBox.Items.Add(item);
            }
        }
        private ApplciationReportCommand getCommandInfoFromReportName(string reportName) {
            ApplciationReportCommand cmd = null;
            for (var i = 0; i < applicationConfiguration.commands.Count; i++)
            {
                if (reportName == applicationConfiguration.commands[i].report_name)
                {
                    cmd = applicationConfiguration.commands[i];
                    break;
                }
            }
            return cmd;
        }






        /*private void runReportBtn_Click3(object sender, EventArgs e)
        {
            if (reportTypeComboBox.Text == "")
            {
                MessageBox.Show("REPORT TYPE NOT SELECTED","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            CurrentSelectedCommand = getCommandInfoFromReportName(reportTypeComboBox.Text);
            if (CurrentSelectedCommand == null)
            {
                MessageBox.Show("SORRY, INVALID REPORT!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSelectedCommand.cmd_arguments = getProcessedArguments(argsTxt.Text);

            //RUN SCRIPT
            logsRichText.Text = "path: " + CurrentSelectedCommand.execution_path;
            logsRichText.Text += "\ncmd: " + CurrentSelectedCommand.execution_path;
            logsRichText.Text += "\nargs: " + CurrentSelectedCommand.execution_path;
            logsRichText.Text += "\nRunning : " + reportTypeComboBox.Text + " ...\n";
            ExecuteCommand(CurrentSelectedCommand.execution_path, CurrentSelectedCommand.working_dir_path,CurrentSelectedCommand.cmd_arguments);
            logsRichText.Text += ("\nCOMPLETED.");
        }*/
       

        private void runReportBtn_Click(object sender, EventArgs e)
        {
            if (reportTypeComboBox.Text == "")
            {
                MessageBox.Show("REPORT TYPE NOT SELECTED", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSelectedCommand = getCommandInfoFromReportName(reportTypeComboBox.Text);
            if (CurrentSelectedCommand == null)
            {
                MessageBox.Show("SORRY, INVALID REPORT!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSelectedCommand.cmd_arguments = getProcessedArguments(argsTxt.Text);

            var commandExecutor = new CommandExecutor(logsRichText);
            //commandExecutor.ExecuteCommand(CurrentSelectedCommand.execution_path, CurrentSelectedCommand.working_dir_path, CurrentSelectedCommand.cmd_arguments);
            //RUN SCRIPT
            logsRichText.Text = "\n\nAPPLICATION : " + reportTypeComboBox.Text + " ...\n";
            logsRichText.Text += "\npath: " + CurrentSelectedCommand.working_dir_path;
            logsRichText.Text += "\ncmd: " + CurrentSelectedCommand.execution_path;
            logsRichText.Text += "\nargs: " + CurrentSelectedCommand.cmd_arguments;
            logsRichText.Text += "\nPlease wait:\nCurrent-Running : " + reportTypeComboBox.Text + " ...\n";
            commandExecutor.ExecuteCommand(CurrentSelectedCommand.execution_path, CurrentSelectedCommand.working_dir_path, CurrentSelectedCommand.cmd_arguments);
            logsRichText.Text += ("\n\nCOMPLETED.");
            MessageBox.Show("COMMAND TASK COMPLETED");
        }


        

        public void ExecuteCommandx(string executionPath, string workingDirPath, string cmdArguments)
        {
            // Create a new process
            using (Process process = new Process())
            {
                // Configure the process start information
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = executionPath, // Path to the executable
                    Arguments = cmdArguments, // Command line arguments
                    WorkingDirectory = workingDirPath, // Directory to run the command from
                    RedirectStandardOutput = false, // Redirect output
                    RedirectStandardError = true, // Redirect error output
                    UseShellExecute = true, // Don't use the shell
                    CreateNoWindow = false // Don't create a console window
                };

                process.StartInfo = startInfo;

                try
                {
                    // Start the process
                    process.Start();

                    // Asynchronously read the output and error streams
                    //process.OutputDataReceived += (sender, e) => AppendLog(e.Data);
                    //process.ErrorDataReceived += (sender, e) => AppendLog(e.Data);
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // Wait for the process to exit
                    process.WaitForExit();

                    // Get the exit code of the process
                    int exitCode = process.ExitCode;
                    AppendLog("Process exited with code: " + exitCode);
                }
                catch (Exception ex)
                {
                    AppendLog("An error occurred: " + ex.Message);
                }
            }
        }

        public void ExecuteCommand1(string executionPath, string workingDirPath, string cmdArguments)
        {
            // Create a new process
            using (Process process = new Process())
            {
                // Configure the process start information
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = executionPath, // Path to the executable
                    Arguments = cmdArguments, // Command line arguments
                    WorkingDirectory = workingDirPath, // Directory to run the command from
                    RedirectStandardOutput = true, // Redirect output
                    RedirectStandardError = true, // Redirect error output
                    UseShellExecute = false, // Don't use the shell
                    CreateNoWindow = true // Don't create a console window
                };

                process.StartInfo = startInfo;

                try
                {
                    // Start the process
                    process.Start();

                    // Read the output (if needed)
                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();



                    // Wait for the process to exit
                    process.WaitForExit();

                    // If needed, handle output and error output
                    if (!string.IsNullOrEmpty(output))
                    {
                        Console.WriteLine("Output:");
                        Console.WriteLine(output);
                        AppendLog(output);
                    }

                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        Console.WriteLine("Error:");
                        Console.WriteLine(errorOutput);
                        AppendLog(errorOutput);
                    }

                    // Get the exit code of the process
                    int exitCode = process.ExitCode;
                    Console.WriteLine("Process exited with code: " + exitCode);
                    AppendLog("Process exited with code: " + exitCode);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    AppendLog("An error occurred:  " + ex.Message);
                }
            }
        }


        private void AppendLog(string message)
        {
            // Ensure that the message is not null or empty
            if (string.IsNullOrEmpty(message)) return;

            // Use Invoke to update the RichTextBox in a thread-safe manner
            if (logsRichText.InvokeRequired)
            {
                logsRichText.Invoke(new Action<string>(AppendLog), message);
            }
            else
            {
                // Append the message to the RichTextBox and scroll to the bottom
                logsRichText.AppendText(message + Environment.NewLine);
                logsRichText.SelectionStart = logsRichText.Text.Length; // Scroll to the bottom
                logsRichText.ScrollToCaret();
            }
        }

        //OPEN CONFIG FOLDER
        private void configLinkTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string configPath = baseController.get_my_path() + @"config\configs.json";

            // Get the directory of the configuration file
            string configDirectory = Path.GetDirectoryName(configPath);

            // Check if the directory exists
            if (Directory.Exists(configDirectory))
            {
                // Start a new process to open Windows Explorer at the specified path
                System.Diagnostics.Process.Start("explorer.exe", configDirectory);
            }
            else
            {
                MessageBox.Show("The configuration directory does not exist.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void reportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplciationReportCommand cmdInfo = getCommandInfoFromReportName(reportTypeComboBox.Text);
            CurrentSelectedCommand = cmdInfo;

            argsTxt.Text = cmdInfo.cmd_arguments;//getProcessedArguments(cmdInfo.cmd_arguments);
            readmeRichTextBox.Text = cmdInfo.report_readme;


        }

        private string getProcessedArguments(string args)
        {
            // Check for placeholders and replace them
            var processedArgs = args;

            // Extract all placeholders in the format <PLACEHOLDER>
            var matches = System.Text.RegularExpressions.Regex.Matches(args, "<(.*?)>");

            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                // Get the placeholder without <>
                string placeholder = match.Groups[1].Value;

                // Get the corresponding actual value
                string replacementValue = getArgumentCmdDefination(placeholder);

                // Replace placeholder with its value in the processed arguments
                processedArgs = processedArgs.Replace(match.Value, replacementValue);
            }

            return processedArgs;
        }

        private string getArgumentCmdDefination(string cmdArg)
        {
            switch (cmdArg)
            {
                case "START_DATE":
                    // Replace this with the actual way to get the date from your DatePicker
                    return startDatePicker.Value.ToString("yyyy-MM-dd"); // Adjust based on your DatePicker logic

                case "END_DATE":
                    // Replace this with the actual way to get the date from your DatePicker
                    return endDatePicker.Value.ToString("yyyy-MM-dd"); // Adjust based on your DatePicker logic

                default: return "";
                    //return $"Unknown command: {cmdArg}"; // Handle unknown placeholders
            }
        }





    }
}

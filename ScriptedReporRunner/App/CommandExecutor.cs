using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptedReporRunner.App
{
    public class CommandExecutor
{
    private RichTextBox logsRichText;

    // Constructor
    public CommandExecutor(RichTextBox logsRichTextBox)
    {
        logsRichText = logsRichTextBox;
    }

        public void ExecuteCommand(string executionPath, string workingDirPath, string cmdArguments)
        {
            // Create a new process
            using (Process process = new Process())
            {
                // Configure the process start information
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe", // Use the CMD executable
                    Arguments = "/C \"" + executionPath + " " + cmdArguments + "\"", // /C to run command and terminate
                    WorkingDirectory = workingDirPath, // Directory to run the command from
                    RedirectStandardInput = false, // Do not redirect input
                    RedirectStandardOutput = false, // Do not redirect output
                    RedirectStandardError = false, // Do not redirect error output
                    UseShellExecute = true, // Use the shell
                    CreateNoWindow = false // Create a console window
                };

                process.StartInfo = startInfo;

                try
                {
                    // Start the process
                    process.Start();
                    // Wait for the process to exit
                    process.WaitForExit();

                    // Get the exit code of the process
                    int exitCode = process.ExitCode;
                    Console.WriteLine("Process exited with code: " + exitCode);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

    public void ExecuteCommand2(string executionPath, string workingDirPath, string cmdArguments)
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

                // Asynchronously read the output and error streams
                process.OutputDataReceived += (sender, e) => AppendLog(e.Data);
                process.ErrorDataReceived += (sender, e) => AppendLog(e.Data);
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
}
}

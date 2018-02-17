using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyPngStockHelper.Properties;

namespace LayoutProject
{
    internal class PicCompressor
    {


        private static string pythonScript = "\"" + Directory.GetCurrentDirectory() + "\\" + "TinyPngExe.py\"";
        private string COMPRESS_SUFIX = "_compressed";
        public static RichTextBox filesRTB;
        private static string pythonPath;
        private static string apiKey;

        //inputs array
        private static string[] picInputs;
        private static int counter;

        public void compressPic(RichTextBox filesRTB, string pythonPath, string apiKey, string[] picInputs)
        {
            PicCompressor.filesRTB = filesRTB;
            PicCompressor.pythonPath = pythonPath;
            filesRTB.Text = "";
            saveParams(apiKey, pythonPath);
            PicCompressor.apiKey = FormatString(apiKey);

            PicCompressor.picInputs = picInputs;
            CompressNextInput();

        }

        public static void CompressNextInput()
        {
            if(counter == picInputs.Length) return;
            var picInputStr = FormatString(picInputs[counter]);
            //string picOutput = picInput.Insert(picInput.LastIndexOf("."), COMPRESS_SUFIX);

            RunCmd(pythonPath, pythonScript, apiKey + picInputStr + picInputStr);
            //RunCmd(pythonPath, PYTHON_SCRIPT, apiKey + picInput + picInput);
        }

        private void saveParams(string apiKey, string pythonPath)
        {
            Settings.Default.Upgrade();
            Settings.Default.APIKey = apiKey;
            Settings.Default.PythonPath = pythonPath;
            Settings.Default.Save();
        }

        private static void RunCmd(string pythonPath, string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonPath;
            start.Arguments = cmd + args;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    filesRTB.AppendText(result);
                    counter++;
                    CompressNextInput();

                }
            }
        }

        private static string FormatString(string inputStr)
        {
            return " \"" + inputStr + "\"";
        }
    }
}
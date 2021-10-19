 using System.Diagnostics;

namespace RemoteManagement
{
    public static class PSTools
    {
        public static void KillRemoteApp(string ip, int userIndex, string appName)
        {
            string arguments = @"\\" + ip + userIndex + " -u " + "\"" + DeviceRemoteDefine.session + "\"" + " -p " + DeviceRemoteDefine.paswword + " " + '"' + appName + '"';
            StartProcess(arguments, "pskill.exe");
        }

        public static void LaunchingRemoteApp(string ip, int userIndex, string appName)
        {
            string arguments =  "-i 1 -d " + @"\\" + ip + userIndex + " -u " + DeviceRemoteDefine.session + " -p " + DeviceRemoteDefine.paswword + " " + '"' + appName + '"';
            StartProcess(arguments, "PsExec.exe");
        }
        public static void ShutdownRemoteDevice(string ip, int userIndex)
        {
            string arguments = @"-s -f -m \\" + ip + userIndex + " -t 0";
            StartProcess(arguments, "shutdown.exe");
        }

        public static void RestartRemoteDevice(string ip, int userIndex)
        {
            string arguments = @"-r -f -m \\" + ip + userIndex + " -t 0";
            StartProcess(arguments, "shutdown.exe");
        }

        public static void KillLocalApp(string appName)
        {
            Process[] processRunning = Process.GetProcessesByName(appName);
            foreach (Process app in processRunning)
                app.Kill();
        }

        public static void LaunchingLocalApp(string appName)
        {
            Process.Start(appName);
        }

        private static void StartProcess(string args, string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = args;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }
    }
}

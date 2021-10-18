 using System.Diagnostics;

/*************************************************************************
*  Copyright � 2020-2021 Hypnogic. All rights reserved.
*------------------------------------------------------------------------
*  File         :  PSTools.cs
*  Description  :  Libreria para el control remoto de dispositivos
*------------------------------------------------------------------------
*  Author       :  Erick
*  Version      :  1.0
*  Date         :  19/08/21
*************************************************************************/

namespace RemoteManagement
{
    public static class PSTools
    {
        #region METODOS PARA CERRAR APLICACIONES DE FORMA LOCAL Y REMOTA

        public static void KillRemoteApp(string ip, int userIndex, string appName)
        {
            string arguments = @"\\" + ip + userIndex + " -u " + "\"" + DeviceRemoteDefine.session + "\"" + " -p " + DeviceRemoteDefine.paswword + " " + '"' + appName + '"';
            StartProcess(arguments, "pskill.exe");
        }

        public static void KillLocalApp(string appName)
        {
            Process[] processRunning = Process.GetProcessesByName(appName);
            foreach (Process app in processRunning)
                app.Kill();
        }

        #endregion

        #region METODOS PARA ABRIR APLICACIONES DE FORMA LOCAL Y REMOTA

        public static void LaunchingRemoteApp(string ip, int userIndex, string appName)
        {
            string arguments =  "-i 1 -d " + @"\\" + ip + userIndex + " -u " + DeviceRemoteDefine.session + " -p " + DeviceRemoteDefine.paswword + " " + '"' + appName + '"';
            StartProcess(arguments, "PsExec.exe");
        }

        public static void LaunchingLocalApp(string appName)
        {
            Process.Start(appName);
        }

        #endregion

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

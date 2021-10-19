using System.Diagnostics;
using UnityEngine;
using RemoteManagement;
using System.IO;

public class DeviceRemoteManager : MonoBehaviour
{
    public string ip = "192.168.0.";
    public int devicesAmount;
    public string remoteApp;

    public void StartRemoteApp()
    {
        for (int i = 0; i < devicesAmount; i++)
        {
            PSTools.LaunchingRemoteApp(ip , i + 1, remoteApp);
            UnityEngine.Debug.Log("Launching app on remote devices " + (i + 1));
        }
    }

    public void KillRemoteApp()
    {
        for (int i = 0; i < devicesAmount; i++)
        {
            PSTools.KillRemoteApp(ip , i + 1, Path.GetFileName(remoteApp));
            UnityEngine.Debug.Log("Killing app on remote devices " + (i + 1));
        }        
    }

    public void ShutdownRemoteDevices()
    {
        for (int i = 0; i < devicesAmount; i++)
        {
            PSTools.ShutdownRemoteDevice(ip, i + 1);
            UnityEngine.Debug.Log("Shutdown remote devices " + (i + 1));
        }
    }

    public void RestartRemoteDevices()
    {
        for (int i = 0; i < devicesAmount; i++)
        {
            PSTools.RestartRemoteDevice(ip, i + 1);
            UnityEngine.Debug.Log("Restart remote devices" + (i + 1));
        }
    }
}

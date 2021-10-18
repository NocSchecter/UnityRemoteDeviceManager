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
            Debug.Log("Launching app on remote device " + (i + 1));
        }
    }

    public void KillRemoteApp()
    {
        for (int i = 0; i < devicesAmount; i++)
        {
            PSTools.KillRemoteApp(ip , i + 1, Path.GetFileName(remoteApp));
            Debug.Log("Killing app on remote device " + (i + 1));
        }        
    }
}

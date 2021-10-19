# Unity Remote Device Manager
Small manager in Unity 2020.3.12f1, which manages the startup and shutdown of an application on a remote device using PStools.

# FEATURES
1. Local and remote start of one or more applications (Supports VR mode applications).
2. Stopping applications locally or remotely.
3. Shutdown of one or more devices remotely.
4. Rebooting one or more devices remotely.

# TO DO

1. Remote device power on using Wake On Lan.

# PREREQUISITES BEFORE USE

Windows
1. Enable incoming "Ping" https://www.youtube.com/watch?v=1BGdvSyAADw
2. Disable "Remote UAC" : https://www.poweradmin.com/help/pa-server-monitor-8-3/howto_disable_remote_uac.aspx
3. Assign an ip range you want pstools to work with.

PSTools suite
1. Download PStools suite from the following link: https://docs.microsoft.com/en-us/sysinternals/downloads/pstools
2. Unzip the file containing PStools suite and copy its contents to the path "C:\\", e.g.
3. Add the path "C:\\PSTools\\" to the windows environment variables.

# HOW TO USE

1. To remotely launch an application, call the method LaunchingRemoteApp inside PStools script.
2. To remotely stop an application, call the method KillRemoteApp inside PSTools script.
3. To launch an application locally, call the method LaunchingLocalApp() iniside PSTools script.
4. To stop an application locally, call the method KillLocalApp() indise PSTools script.

# KNOWN ISSUES

1. There is instability in having two user accounts and switching between them.

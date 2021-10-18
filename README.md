# Unity Remote Device Manager
Small manager in Unity 2020.3.12f1, which manages the startup and shutdown of an application on a remote device using PStools.

FEATURES
1. Local and remote start of one or more applications (processes).
2. Stopping applications (processes) locally or remotely

TO DO

1. Remote device shutdown.
2. Remote device reboot.
3. Remote device power on using Wake On Lan.

PREREQUISITES BEFORE USE

Windows
1. Enable the "Shared files and printers" inbound rule in the firewall.
2. Add "LocalAccountPolicyFilter" registry in regedit.
3. Assign an ip range you want pstools to work with.

PSTools suite
1. Download PStools suite from the following link: https://docs.microsoft.com/en-us/sysinternals/downloads/pstools
2. Unzip the file containing PStools suite and copy its contents to the path "C:\", e.g.
3. Add the path C:\PSTools\ to the windows environment variables.

HOW TO USE

1. To remotely launch an application, call the method LaunchingRemoteApp inside PStools script.
2. TTo remotely stop an application, call the method KillRemoteApp inside PSTools script.
3. To launch an application locally, call the method LaunchingLocalApp() iniside PSTools script.
4. To stop an application locally, call the method KillLocalApp() indise PSTools script.

LIMITATIONS

1.There is instability in having two user accounts and switching between them.

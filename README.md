# Unity Remote Device Manager
Small manager in Unity 2020.3.12f1, which manages the startup and shutdown of an application on a remote device using PStools.

Prerequisites

Windows
1. Enable the "Shared files and printers" inbound rule in the firewall.
2. Add "LocalAccountPolicyFilter" registry in regedit.
3. Assign an ip range you want pstools to work with.

PSTools suite
1. Download PStools suite from the following link: https://docs.microsoft.com/en-us/sysinternals/downloads/pstools
2. Unzip the file containing PStools suite and copy its contents to the path "C:\", e.g.
3. Add the path C:\PSTools\ to the windows environment variables.

How to use

1. To launch a process: call LaunchingRemoteApp inside PStools.
2. To stop a process: call KillRemoteApp inside PSTools.

Limitations: 

1.There is instability in having two user accounts and switching between them.

To do:

1. Remote device shutdown.
2. Remote device reboot.
3. Remote device power on using Wake On Lan

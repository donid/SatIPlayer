# SatIPlayer
A Sat>IP Video Player for Windows that uses the VLC video rendering control but provides a custom-tailored GUI for satellite over IP use (SatIP).

[VLC](https://www.videolan.org) can be used to watch Sat>IP, but I found its GUI quite inconvenient for this use-case, so I created SatIPlayer.
Another benefit of this repository is that you can use it as sample code how to use the [VLC .Net Control](https://github.com/ZeBobo5/Vlc.DotNet).

Some icons from taken from [Icons8](https://icons8.com).
GUI-Controls and other icons from [DevExpress](https://www.devexpress.com)

SatIPlayer needs an INBOUND Firewall-rule for ALLOW : Protocol Type: UDP, Specific Ports: 9108, 9109

If Windows-Firewall dialog appears: allow access for SatIPlayer and restart SatIPlayer.

**Usage:**

SatIPlayer uses an existing VLC installation, which must be located in the default path (**32bit:** C:\Program Files (x86)\VideoLAN\VLC **64bit:** C:\Program Files\VideoLAN\VLC).

**Attention:** If you have only installed 32bit VLC, you need to start *SatIPlayer_32bit.exe*

Testet with VLC 3.0.8 and 3.0.10

# SatIPlayer

A Sat>IP Video Player for Windows that uses the VLC video rendering control but provides a custom-tailored GUI for satellite over IP use (SatIP).

[VLC](https://www.videolan.org) can be used to watch Sat>IP, but I found its GUI quite inconvenient for this use-case, so I created SatIPlayer.
Another benefit of this repository is that you can use it as sample code how to use the [VLC .Net Control](https://github.com/ZeBobo5/Vlc.DotNet).

Some icons taken from [Icons8](https://icons8.com).
GUI-Controls and other icons from [DevExpress](https://www.devexpress.com)

SatIPlayer needs an INBOUND Firewall-rule for ALLOW : Protocol Type: UDP, Specific Ports: 9108, 9109

If Windows-Firewall dialog appears: allow access for SatIPlayer and restart SatIPlayer.

**Usage:**

SatIPlayer uses an existing VLC installation, which must be located in the default path (**32bit:** C:\Program Files (x86)\VideoLAN\VLC **64bit:** C:\Program Files\VideoLAN\VLC).

**Attention:** If you have only installed 32bit VLC, you need to start *SatIPlayer_32bit.exe*

Testet with VLC 3.0.8, 3.0.10, 3.0.17.4

## New Tool: SatIpUrlGenerator

This Tool can generate Sat>IP URLs for use in the .m3u playlist files or with the "Media / Open Network Stream"-feature of VLC. The input data can be taken from *<www.satindex.de>* or *<www.digitalfernsehen.de/sat-frequenzen>*

## New playlist file

The .m3u file at <http://www.satip.info/Playlists> has been out of date for a long time, and as of June 2024, the site appears to be completely down.

So, SatIPlayer switched to using <https://github.com/dersnyke/satipplaylists>, which allowed to remove many entries in the custom channels file *ASTRA_19_2E_custom.m3u*.

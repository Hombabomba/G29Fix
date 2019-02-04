# G29 Fix by Hombabomba

You probably played Project Cars 2 (PC2) and have problems with your wheel now.
I made a small programm to fix these problems.
The problems are because PC2 is writing their settings in the Registry and not resetting them after you close the game.
You can manually change these two values:
1.  Press Windowskey and type in regedit
2.  Go to HKEY_CURRENT_USER\System\CurrentControlSet\Control\MediaProperties\PrivateProperties\Joystick\OEM\VID_046D&PID_C24F
3.  Change the value of OEMName to "Logitech G29 Driving Force Racing Wheel USB"
    & change the value of OEMData to "43 00 08 10 19 00 00 00"
4. You're done and you can play now

But since you need to do this everytime after you play PC2 and change to almost any other game where you want to use your wheel, you can just use my little programm. It's probably asking for the permission to start as admin. Don't worry source code is in here aswell if you don't trust me.

So if you use my programm instead of doing it manually,
##### start the G29Fix.exe and you're ready to play

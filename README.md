# WeMosMenu
A C# menu for personal use with WeMos D1 R2 wifi board, url checking, command activation
lots of debug areas commented out, struggled a bit with checking url method to not increase the count for 
previously selected data/url. There's no check for invalid urls entered such as 1234567890, http:// is appended
so a 1.0.36.28 number comes up for http address. The WeMos wifi address is 192.168.4.1 so I've put that into a button
instead..so no typos. The other buttons could be setup as commands to send to the WeMos, haven't implemented that yet.

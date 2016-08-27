# UWP_Tut_Proj_1
**Windows 10 UWP Tutorial Series**

<br><br>
Tutorial
-----
This project is intended to accompany the tutorial that I've created. You can follow my tutorial series below.

- **Part 1 - Create and deploy your first UWP app project**<br>
  Branch: **master (UWP_Tut_Proj_1)**<br>
  [Tutorial](http://blog.whoisrizkipratama.net/tutorial-uwp-1-create-deploy-first-windows-10-uwp-app) (Indonesian) | [Download Project](https://github.com/softtama/UWP_Tut_Proj_1/archive/master.zip)

- **Part 2 - Set app name, description, and its visual assets**<br>
  Branch: **UWP_Tut_Proj_1.1**<br>
  [Tutorial](http://blog.whoisrizkipratama.net/tutorial-uwp-2-set-app-name-description-visual-assets/) (Indonesian) | [Download Project](https://github.com/softtama/UWP_Tut_Proj_1/archive/UWP_Tut_Proj_1.1.zip)

- **Part 3 - Add control elements (text box, button, etc.)**<br>
  Branch: **UWP_Tut_Proj_1.2**<br>
  ~~Tutorial~~ | [Download Project](https://github.com/softtama/UWP_Tut_Proj_1/archive/UWP_Tut_Proj_1.2.zip)

<br><br>
How to sideload apps?
-----
### PC/Desktop
1. Right click at file named **Add-AppDevPackage.ps1**.
2. Select **"Run with PowerShell"**.
3. If it asking you permission to do something related to the app installation, just grant it.
4. Enjoy the app.

### Phone
1. Make sure your PC and phone are connected to the same network (e.g. Wi-Fi).
2. On your phone, go to **Settings**. Choose **Update & security**, then choose **For developers**. Enable **Device discovery** and press the **Pair** button to get 6 digit PIN for authentication.
3. Still on your phone, under **Device Portal**, enable **Turn on remote diagnostic over USB and local area network connections**.
4. On your PC, open browser and go to IP address displayed under Connect using (started with https://).
5. If asking for 6 digit PIN, enter the PIN you get before.
6. Under Utilities, click **Apps**.
7. Under App Manager, go to **Install app** section, select **Choose file** under App package, and select *.appx or *.appxbundle file you want to install.
8. Select **Add dependency** to choose dependency file.
9. Under Deploy, click **Go** to start installing app.
10. Enjoy the app on your phone.

<br><br>
Authors and Licenses
-----
Windows 10 UWP Tutorial Series are created and authored by [Rizki Pratama](https://twitter.com/softtama)<br>
Copyright © 2016 Rizki Pratama<br>
MIT License

# simple-vr-app
A simple Virtual Reality application using Unity and intended to be deployed to Oculus Go. This application was made for a tech talk at Facebook Developer Circles Bandung June 2018 meetup along with my presentation slide at https://docs.google.com/presentation/d/1gKiZjflNSX4MSxUf_K3t7qpPfkxrNDnuNZKYVTWyrKs/edit?usp=sharing

## How to Run
```
1. Install Unity and register at oculus.com
2. Open the project with Unity
3. If not chosen, choose MainScene at Scene directory
4. Enable developer mode on your Oculus Go
5. Connect the Oculus Go to laptop via micro-USB
6. In Oculus Go device, a message will be shown, choose allow USB debugging
7. You can deploy to Oculus Go with this two options:
  a. Choose Build and Run at Unity
  b. Build the apk first and then use CLI with command “adb install [apkname]”
8. The deployed application will be available at Library -> Unknown Sources
9. Open the app, look around at the objects and use the Touchpad to move
```

## Enabling developer mode on Oculus Go
```
1. Go to https://oculus.com
  a. Register (the account must be the same with the account used on Oculus Go)
  b. Open https://dashboard.oculus.com
  c. Create a new Organization
2. Download Oculus application on mobile phone and use it to pair with Oculus Go
3. Open Oculus application in the mobile phone
  a. Open Settings
  b. Select the Oculus Go
  c. Select More Settings 
  d. Toggle Developer Mode on
```

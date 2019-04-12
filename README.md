# Gesture Based User Interface Project
#### Authors: Ray Mannion & John Mannion
#### Lecturer: Damien Costello
#### Hardware: Kinect v2.0 & Windows Adaptor for Kinect
#### Software: Visual Studio & Unity 3d
#### Project Title: Kinect-Breaker

### Requirements
Due Date: 12th April 2019 (or earlier is acceptable)
Develop an application with a Natural User Interface. There are a number of options available to
you and this is an opportunity to combine a lot of technology that you have worked with over the
past four years.

At the very least, this should be a local implementation of the application using gestures to interact
with it. For example, a voice controlled application fits the parameters of gesture based control. You
can expand out to include real-world hardware and use this as an opportunity to prove a concept.
The Internet of Things is a common phrase, so you could implement a solution taking advantage of
hardware like the Raspberry Pi, using the cloud for data transfer and creating a real-world scenario
through this medium.

You can reproduce a classic game or system using a gesture-based interface. For example, a
platformer game or a navigation application using Kinect or voice control. Maybe Tetris using the
Myo armbands to control the blocks, or Flappy Bird using the Kinect as the controller. Applications
with multiple users are also acceptable.
Voice control applications need to be more complex and achieve something. Creating a skill in Alexa
for the sake of creating a skill is not enough. You need to take the application further than this. You
could, for example, implement a simple learning mechanism that will build a conversational skill as
time progresses and demonstrate this. You could use the voice control to progress through a game
or achieve a task. If you are doing this, then you need to distinguish the code you write from the
samples available.

### Research
The devices available to us in class included
* Myo Armbands

![myo](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/myo.jpg)

Using proprietary EMG sensors, the Myo armband measures electrical activity from your muscles to detect five gestures made by your hands. Using a 9-axis IMU, it also senses the motion, orientation and rotation of your forearm. The Myo armband transmits this information over a Bluetooth Smart connection to communicate with compatible devices. Myo also streams the raw EMG and IMU data for developers to utilize in their projects and applications. You can dowload the myo connect and SDK [here](https://support.getmyo.com/hc/en-us/articles/360018409792).

* Leap Motion Controllers

![leap](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/leap.png)


From a hardware perspective, the Leap Motion Controller is actually quite simple. The heart of the device consists of two cameras and three infrared LEDs. These track infrared light with a wavelength of 850 nanometers, which is outside the visible light spectrum. Thanks to its wide angle lenses, the device has a large interaction space of eight cubic feet.

Once the image data is streamed to your computer, it’s time for some heavy mathematical lifting. Despite popular misconceptions, the Leap Motion Controller doesn’t generate a depth map – instead it applies advanced algorithms to the raw sensor data.

The Leap Motion Service is the software on your computer that processes the images. After compensating for background objects (such as heads) and ambient environmental lighting, the images are analyzed to reconstruct a 3D representation of what the device sees.

* Kinect v2.0

![kinect](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/kinect.jpg)

Field of View: 70˚ horizontal by 60˚ vertical

Resolvable Depth: 0.8 m -> 4.0 m

Colour Stream: 1920 x 1080 x 16 bpp 16:9 YUY2 @ 30 fps

Depth Stream: 512 x 424 x 16 bpp, 13-bit depth

Infrared Stream: 512 x 424, 11-bit dynamic range

Registration: Colour <-> depth and active IR

Audio Capture: 4-mic array returning 48K Hz audio

Data Path: USB 3.0

Latency: ~60 ms with processing

Tilt Motor: No tilt motor

* Hololens

![halolens](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/halo.jpeg)


The HoloLens is a "mixed reality" headset that projects 3D holograms onto the lenses. The wearer can move around the object, manipulate it, and experience it as if it were actually present. Hand controls, similar to those used with the Microsoft Kinect, allow the wearer to manipulate the 3D projections as well. And HoloLens will display 2D windows so you can use it with some traditional apps too.

### Outcome
The research stage of this project was quite interesting and revealed a lot of new challenges. This was the first time we attempted a project using gesture based technologies. The first challenge was to choose the correct device for our needs and discover what additional software/hardware might be required.

We choose the Kinect v2.0 as we already had one at our disposal but not the windows adaptor. This was provided to us by our lecturer Damien Costello. We performed extensive searches to get a better understanding of other Kinect projects so we could understand the potential and limitations of the Kinect sensor. Once we decided on our project we got started and decided on what gestures we wanted to use.

### Project
For this project we used the Kinect 2.0 to create a gesture-based game using unity3d. We are
planning on recreating the classic Atari game super breakout. The game will include multiple rows of
breakable blocks, within a structure, at the top of the screen. There will be a paddle at the bottom
that will be controlled by the player by leaning either left or right in order to stop a ball from
falling off the screen. The same ball will be used to try to destroy the bricks at the top of the screen.

### Hardware
This project was created using Kinect 2.0. The Kinect (codenamed Project Natal during development) is a line of motion sensing input devices produced by Microsoft. Initially, the Kinect was developed as a gaming accessory for Xbox 360 and Xbox One video game consoles and Microsoft Windows PCs. Based around a webcam-style add-on peripheral, it enabled users to control and interact with their console/computer without the need for a game controller, through a natural user interface using gestures and spoken commands.

![kinect](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/kinect.jpg)

The Kinect also connects to your PC via the Kinect adaptor for windows.

#### Kinect Adaptor requires a USB 3 port on your PC.

![adaptor](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/adaptor.jpg)

### Software
To develop a project with Kinect 2.0 you must install the Kinect for windows [SDK 2.0](https://www.microsoft.com/en-us/download/details.aspx?id=44561). The SDK is freely available to download from Microsoft. To develop with [Unity 3d](https://unity3d.com/get-unity/download) you must also download the [KinectForWindows_UnityPro_2.0.1410](https://go.microsoft.com/fwlink/?LinkID=513177) plug in which again is also freely available to download from Microsoft. The IDE we choose to use was [Visual Studio](https://visualstudio.microsoft.com/) 2015.

 Once the adaptor is connected to your machine it will automatically install three pieces of software that are required to use the Kinect.

* Kinect Studio v2.0
* SDK Browser v2.0 (Kinect for windows)
* Visual Gesture Builder

Once the Kinect software was installed we used the SDK browser to run the Kinect configuration tool to ensure it was correctly set up and ready to work with.

In Unity 3d you must import the KinectForWindows_UnityPro_2.0.1410 plug in into your Unity project for the Kinect to work.

### Gestures
The gestures we chose to use for this project are lean left and lean right. The reason we chose the
gestures was to allow a wide variety of players to play the game. This would allow a user to play the game
in either a seated or standing position. This would also allow the game to be played by users who may not have the use of their arms as it relies on shoulder movement.

We decided to create a series of custom gestures for our project using  Kinect studio and the visual gesture builder. This involved recording a lean to the left and a lean to the right, then a step to the left and a step to the right. This video was used to train the database of gestures and done using the Kinect Studio Software.

![kinectStudio](https://github.com/rayman51/GBUi_KinectProject/blob/master/KinectSreens/Screenshot1.png)
#### Database
After we had our training video, we moved to the gesture builder to create a solution. Here we imported our training video and created 2 gestures for the database.
This was done by moving slowly through you training video and marking the points where you gesture begins and ends.

![Gestures](https://github.com/rayman51/GBUi_KinectProject/blob/master/KinectSreens/Screenshot14.png)
![Gestures2](https://github.com/rayman51/GBUi_KinectProject/blob/master/KinectSreens/Screenshot15.png)


This was followed by recording random gestures including the leans and steps to use as test data to train the Kinect to recognise the custom gestures.

### Conclusions & Recommendations
The Kinect v2.0 had a lot of potential when it was originally released in 2013 with the Xbox one. The success of the original Kinect sensor led Microsoft to further the development of gesture based technology and voice control. The progress of the device has since halted and Microsoft no longer ship the Kinect v2.0 with the consoles. As a result of this decision, which was probably down to the initial cost of the device, the Kinect is almost dead in the water. There are somewhat limited documentation and tutorials available when it comes to development with the Kinect v2.0 which is a shame as it was very enjoyable to create this project.

I would recommend that Microsoft should encourage developers to use Kinect but it doesn't look likely as they have currently stopped manufacturing of the device, and the adaptor, in an attempt to explore their new mixed reality devices (HoloLens, HoloLens 2) which coincidently uses Kinect technologies for depth-sensing, and many laptops now ship with Windows Hello cameras that use the learnings of Kinect to recognize people’s faces.

Unfortunately [Kinect](https://www.polygon.com/2017/10/25/16543192/kinect-discontinued-microsoft-announcement) and the [Windows Adaptor](https://www.polygon.com/2018/1/2/16842072/xbox-one-kinect-adapter-out-of-stock-production-ended) is no more.

### Video Demonstration

# Gesture Based User Interface Project
### Authors: Ray Mannion & John Mannion
### Lecturer: Damien Costello
### Hardware/Software: Kinect 2.0, Visual Studio
### Project Title: Kinect-Breaker

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

### Project
For this project we used the Kinect 2.0 to create a gesture-based game using unity3d. We are
planning on recreating the classic Atari game super breakout. The game will include multiple rows of
breakable blocks, within a structure, at the top of the screen. There will be a paddle at the bottom
that will be controlled by the player by leaning either left or right in order to stop a ball from
falling off the screen. The same ball will be used to try to destroy the bricks at the top of the screen.

### Gestures
The gestures we chose to use for this project are lean left and lean right. The reason we chose the
gestures was to allow a wide variety of players to play the game. This would allow a user to play the game
in either a seated or standing position. This would also allow the game to be played by users who may not have the use of their arms as it relies on shoulder movement.

### Hardware
This project was created using Kinect 2.0. The Kinect (codenamed Project Natal during development) is a line of motion sensing input devices produced by Microsoft. Initially, the Kinect was developed as a gaming accessory for Xbox 360 and Xbox One video game consoles and Microsoft Windows PCs. Based around a webcam-style add-on peripheral, it enabled users to control and interact with their console/computer without the need for a game controller, through a natural user interface using gestures and spoken commands.

![kinect](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/kinect.jpg)

The Kinect also connects to your PC via the Kinect adaptor for windows. This requires a USB 3 port on your PC. Once the Kinect is set up on your machine Kinect will automatically install three pieces of software that are required to use the Kinect.

![adaptor](https://github.com/rayman51/GBUi_KinectProject/blob/master/images/adaptor.jpg)
* Kinect Studio v2.0
* SDK Browser v2.0 (Kinect for windows)
* Visual Gesture Builder

### Software
To develop a project with Kinect 2.0 you must install the Kinect for windows [SDK 2.0](https://www.microsoft.com/en-us/download/details.aspx?id=44561). The SDK is freely available to download from Microsoft. To develop with [Unity 3d](https://unity3d.com/get-unity/download) you must also download the [KinectForWindows_UnityPro_2.0.1410](https://go.microsoft.com/fwlink/?LinkID=513177) plug in which again is also freely available to download from Microsoft. The IDE we choose to use was [Visual Studio](https://visualstudio.microsoft.com/) 2015.

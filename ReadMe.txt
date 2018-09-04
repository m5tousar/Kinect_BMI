Reading this file will help understand the hardware and software that is being used for this project. 


BMI Project

Hardware:
	* Kinect v2 with Kinect for windows and must require Kinect sdk
	* OpenScale RedBoard with load-cell (best if you buy a digital scale and attach 
	  the load-cell to the RedBoard)
	* A computer with windows 10 installed 

Software:
	* Visual Studio 2013
	* Processing (For using Kinect)
	* Arduino IDE (To calibrate the weight scale)

You should be able to launch the Executable and only play with the GUI without meeting any of the software and hardware specification. Use the BMI.csproj in the folder BMI to use the most updated version. 

Code for height and waist size is in the folder BMI->BMI->bin->Debug->source 
You must calibrate the camera by figuring out Pixel to Inches ratio in order for it to give you the correct value.

The GUI only runs the executables that is responsible for getting height and waist size. It also opens the port to read the current weight on the weight scale. 


Here is a small video I've made explaining the project and showing live demo or it working. 

https://drive.google.com/file/d/1MK4PTULYR6Ii2cgCGhmV3s7m_RKED4Uz/view?usp=sharing


# Multi Cast Network

## Table of Contents
- [Project Description](#project-description)
- [Technologies Used](#technologies-used)
- [How to install or run the project](#how-to-run-project)
- [How to use the projcet](#how-to-use-product)
- [Contact Information](#contact-information)

## <a id="project-description">Project Description</a>
In the world of online gaming, networking often goes unnoticed despite its crucial importance. To enhance our understanding of what happens behind the scenes, I have developed a multi-threaded Multicast Network that enables communication between two separate processes over a network.

This application creates an instance of the Multicast Network, which sets up the necessary sockets for data transmission upon instantiation. To receive data, one must call the "execute" function, which creates a thread dedicated to listening on the socket for incoming packets.

One of the main challenges encountered during this project was comprehending the network's design. Initially, it was difficult to realize that there is no single host, as each connection results in a new host capable of listening to and receiving data. Furthermore, understanding that using "localhost" as the IP address was incorrect and that Multicast Networks belong to Class D, with a range of IP addresses from 224.0.0.0 to 239.255.255.255.

To explore the functionality, follow the instructions below, which will involve opening multiple terminals. One terminal will serve as the sending host, while the other will act as the listener. The sender terminal will transmit packets on the network, and both the sender and receiver terminals will be able to receive the packets.

![image](https://github.com/Rshokar/Multi-Cast-Network/assets/60485121/7215fa41-a5ef-4d41-b1ea-87dfcc9de706)

## <a id="technologies-used">Technologies Used</a>
#### Languages
- C#

## <a id="how-to-run-project">How to install or run the project</a>

### Prerequisites:
To get started with the project, make sure you have the following:

- Git and GitHub account
- Visual Studio Code is installed

### Cloning the repository:

- Open Command Prompt
- `cd` into the folder you want the repository stored in
- Type: `git clone [https://github.com/Rshokar/trucking-app]`

### Running the project:

#### 1.Compiling The project
1. Open `Developer Command Promt for VS 2022`
2. Navigate to the folder where the code is stored.
3. Type: `csc Threads\Thread.cs Threads\GameThread.cs Threads\UserThread.cs Packet\Packet.cs Network\Network.cs Network\MulticastNetwork.cs Program.cs`

#### 1.5 Running The Project
1. Create a Listener
2. Create a Sender

#### 2.Create Listener
1. Open `Developer Command Promt for VS 2022`
2. Navigate to the folder where the code is stored.
3. Type: `Program.exe Listener`
4. You will see the message "Network Listening" displayed.

#### 3.Create Sender
1. Open `Developer Command Promt for VS 2022`
2. Navigate to the folder where the code is stored.
3. Type: `Program.exe`
4. You will see `Execute` will appear in the terminal
5. After a brief pause the packets sent and recieved are printed on the screen

## <a id="contact-information">Contact Information</a>

### Ravinder Shokar
- ravindershokar@gmail.com
- https://www.linkedin.com/in/rshokar/
- https://ravindershokar.com/

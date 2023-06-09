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

## <a id="technologies-used">Technologies Used</a>
#### Languages
- C#

## <a id="how-to-run-project">How to install or run the project</a>

### Prerequisites:
To get started with the project, make sure you have the following:

- Git and GitHub account
- Python installed
- Pip installed
- Npx installed
- Expo installed

### Cloning the repository:

- Open Command Prompt
- `cd` into the folder you want the repository stored in
- Type: `git clone [https://github.com/Rshokar/trucking-app]`

### Running the project:

#### 1.Running API Test
1. Open Command Prompt
2. `cd` into the folder where the code is stored
3. Type: `cd trucking-app-flask`
4. Type: `.venv\Scripts\activate`
5. (.venv) should appear on the left side command line line. 
6. Type: `pip install -r requirements.txt`
7. packages should be installed
8. Type: `cd tests`
9. Type: `pytest`

#### 2.Running The API 
1. Open Command Prompt
2. `cd` into the folder where the code is stored
3. Type: `cd trucking-app-flask`
4. Type: `.venv\Scripts\activate`
5. (.venv) should appear on the left side command line line. 
6. Type: `pip install -r requirements.txt`
7. packages should be installed
8. Type: `python -m flask run`

#### 3.Running The Client
1. Open Command Prompt
2. `cd` into the folder where the code is stored
3. Type: `cd trucking-app-client`
4. Type: `npx expo install`
5. Type: `npx expo start`
<br>

## <a id="how-to-use-product">How to use the product (Features)</a>

### Features

#### API (TO-DO)

#### Client (TO-DO)

## <a id="contact-information">Contact Information</a>

### Ravinder Shokar
- ravindershokar@gmail.com
- https://www.linkedin.com/in/rshokar/

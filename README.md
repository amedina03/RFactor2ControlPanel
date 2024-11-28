# rFactor2 Control Console
This application allows for remote management of up to 8 stations running the game **rFactor2** from a central administrator's console. It consists of two main components:

### 1. **rFactor2Api**
This component needs to be installed on each computer running **rFactor2**. Follow the steps below to set it up:

- Download and run the API on each game station. Ensure you run it as an administrator.
- If you'd prefer to create a standalone executable file, you can use **pyinstaller** with the following command:
  ```bash
  pyinstaller --onefile rfactor2api.py
  ```
This will generate an executable for easier deployment.

### 2. **Server Admin**
This is the control console that runs on the main administrator's computer. It allows you to remotely manage the stations. To create the executable:

- Compile the program and click **Publish**. This will generate an executable at:
bash
```bash
  Server Admin/bin/Release/neo8.0-windows
```
- Again, ensure the executable is run as an administrator.

---
### Usage Instructions
1. Select Difficulty Level:
The system offers predefined difficulty levels from Green to Red, affecting settings like: Shift mode, Stability control, Auto brakes. Select the appropriate difficulty level based on your needs.
If you want to customize them you need to modify the file optionsData.json inside of C:/Program Files(x86)/rFactorServerAdmin

3. Configure the Player's System:

- **ID Field**: Choose the computer from the dropdown list, this list can be edited in the file machineData.json in C:/Program Files(x86)/rFactorServerAdmin
- **Name Field**: Input the name of the user playing on that station.
- **Server Field**: Choose the computer from the dropdown list, this list can be edited in the file serverData.json in C:/Program Files(x86)/rFactorServerAdmin

3. Save and Start:

- After configuring the details, click the **Save** button.
- Then, press the **On** button (top right) to launch the game. A confirmation message will appear once the game has successfully opened.
- Finally, click the **Join** button to connect the player's system to the designated server.

4. Managing the Race:
When the race is over, use the button with the **checkered flag** icon to send the system back to the time screen.

---

### Important Notes
- **Do not manually close the game**: Always use the console’s provided button to shut down the game.
- **Preserve the format**: When modifying files for customization make sure to use the same format as it has by default, if after a modification the application stops working properly erase the files and start it again, this will create another set of example files.
- **For configuration changes** (e.g., changing player names or difficulty settings):
  - Close the game using the **top-right close button** in the console.
  - Update the settings, save them, and reopen the game.

---

### Features
- Supports up to 8 game stations.
- Remote control for starting, stopping, and managing servers.
- Adjustable difficulty settings for individual stations.
- Simplified workflow for managing player configurations without needing direct access to the stations.

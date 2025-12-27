# WaveRead
An inedpendent project to predict ocean conditions for surfers. 

Surf Prediction Desktop App Outline
Phase 1: Setup & Foundation

Set up Git repository (GitHub)
Choose your language (C# or Python - decide now)
Create project structure with proper folders
Set up .gitignore
Write a basic README explaining what you're building

Phase 2: Data Acquisition

Research surf/weather APIs (NOAA, Stormglass, OpenMeteo, etc.)
Get API keys where needed
Build a module to fetch basic data (wave height, period, wind speed/direction)
Test that you can successfully retrieve data
Store configuration (API keys) properly (not in Git!)
Wave Height (in feet or meters)
Wave Period (seconds between waves - longer is usually better)
Wave Direction (where the swell is coming from)
Wind Speed & Direction (offshore wind = good, onshore = bad)
Tide data (optional but useful)

BUOYS from National Data Buoy Center
# WAVES -------------------------------WAVES
SSBN7 - https://www.ndbc.noaa.gov/data/realtime2/SSBN7.spec
41204 -   
MROS1 -
41002 - https://www.ndbc.noaa.gov/data/realtime2/41002.spec
41013 - https://www.ndbc.noaa.gov/data/realtime2/41013.spec
41004 - https://www.ndbc.noaa.gov/data/realtime2/41004.spec
41029 - 
41076 - https://www.ndbc.noaa.gov/data/realtime2/41076.spec

# WEATHER --------------------------- WEATHER
#             Weather                                               ocean temp
SSBN7 -
41204 - https://www.ndbc.noaa.gov/data/realtime2/41024.txt https://www.ndbc.noaa.gov/data/realtime2/41024.ocean
MROS1 - https://www.ndbc.noaa.gov/data/realtime2/MROS1.txt
41002 - https://www.ndbc.noaa.gov/data/realtime2/41002.txt
41013 - https://www.ndbc.noaa.gov/data/realtime2/41013.txt
41004 - https://www.ndbc.noaa.gov/data/realtime2/41004.txt
41029 - https://www.ndbc.noaa.gov/data/realtime2/41029.txt https://www.ndbc.noaa.gov/data/realtime2/41029.ocean
41076 - https://www.ndbc.noaa.gov/data/realtime2/41076.txt




Phase 3: Data Storage & Management

Decide how to store fetched data (files, SQLite database, or just in-memory)
Create data models/classes for surf conditions
Build functionality to save and retrieve historical data

Phase 4: Prediction Logic

Research what makes "good" surf conditions (wave height, period, wind direction, tide)
Create a scoring/rating system
Implement basic prediction algorithm
Test with real data

Phase 5: User Interface

Build basic GUI (WPF/WinForms if C#, Tkinter/PyQt if Python)
Display current conditions
Show forecast for next few days
Add location selection

Phase 6: Polish & Features

Add charts/visualizations
Implement your personal preferences (what YOU consider good surf)
Error handling
Testing with different locations/conditions
Set up .gitignore
Write a basic README explaining what you're building

Phase 2: Data Acquisition

Research surf/weather APIs (NOAA, Stormglass, OpenMeteo, etc.)
Get API keys where needed
Build a module to fetch basic data (wave height, period, wind speed/direction)
Test that you can successfully retrieve data
Store configuration (API keys) properly (not in Git!)

Phase 3: Data Storage & Management

Decide how to store fetched data (files, SQLite database, or just in-memory)
Create data models/classes for surf conditions
Build functionality to save and retrieve historical data

Phase 4: Prediction Logic

Research what makes "good" surf conditions (wave height, period, wind direction, tide)
Create a scoring/rating system
Implement basic prediction algorithm
Test with real data

Phase 5: User Interface

Build basic GUI (WPF/WinForms if C#, Tkinter/PyQt if Python)
Display current conditions
Show forecast for next few days
Add location selection

Phase 6: Polish & Features

Add charts/visualizations
Implement your personal preferences (what YOU consider good surf)
Error handling
Testing with different locations/conditions
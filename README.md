# Media Player

A desktop music player application developed with **C# and Windows Forms**. The project allows users to load and manage multiple audio files and control their playback through a simple graphical interface.

The project was created to practice **C# programming, object-oriented programming, event-driven programming, and Windows Forms development**.

    images/
    Screenshot 2026-08-31 224909.png

## Features

* Open and load multiple audio files
* Display loaded tracks in a playlist
* Play, pause, and stop audio
* Navigate to the next or previous track
* Restart the current track
* Volume control
* Playback progress bar
* Display the current playback time
* Switch between elapsed time and total track duration
* Graphical user interface built with Windows Forms

## Technologies

* **C#**
* **.NET Framework 4.8**
* **Windows Forms**
* **Windows Media Player / WMPLib**
* **Object-Oriented Programming**

## Project Structure



## Object-Oriented Programming

The project includes basic OOP concepts through the `Track` class and `IPlayable` interface.

### IPlayable

The `IPlayable` interface defines the basic playback operations:

```csharp
public interface IPlayable
{
    void Play();
    void Pause();
    void Stop();
}
```

### Track

The `Track` class represents an individual audio track and contains:

* Track name
* File path
* Duration

It implements the `IPlayable` interface and demonstrates the use of classes, properties, constructors, and interfaces.

## How It Works

When the user selects **Open**, a file dialog allows multiple audio files to be selected.

The application stores:

* The file names for displaying in the playlist
* The file paths for accessing the actual audio files
* `Track` objects representing the loaded tracks

Selecting a track loads its file into Windows Media Player and starts playback.

The application uses Windows Forms event handlers to respond to user actions such as:

* Button clicks
* Playlist selection
* Volume changes
* Timer updates

A timer periodically updates the playback progress and displayed track time.

## Playback Controls

| Control      | Function                            |
| ------------ | ----------------------------------- |
| Play         | Starts playback                     |
| Pause        | Pauses the current track            |
| Stop         | Stops playback                      |
| Next         | Moves to the next track             |
| Previous     | Moves to the previous track         |
| Volume       | Changes playback volume             |
| Progress Bar | Shows the current playback position |
| Track Time   | Displays playback time / duration   |
| Open         | Adds audio files to the playlist    |

## Purpose

This project was developed as a practical exercise in **C# and desktop application development**.

The main goals were to practice:

* C# syntax and programming fundamentals
* Classes and objects
* Interfaces
* Encapsulation
* Collections
* Event handling
* GUI development
* Working with external components through `WMPLib`

## Future Improvements

Possible improvements include:

* Removing duplicate playlist data structures
* Connecting the `Track` objects directly to the playback logic
* Adding automatic track duration detection
* Adding a proper playlist management system
* Allowing tracks to be removed from the playlist
* Adding shuffle and repeat modes
* Adding album artwork and track metadata
* Improving the separation between the user interface and application logic
* Adding error handling for unsupported or missing audio files

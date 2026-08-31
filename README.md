<img width="386" height="299" alt="Screenshot 2026-08-31 224909" src="https://github.com/user-attachments/assets/186477f1-a696-4b94-87d5-73f7d912a1b5" />
# Media Player

A desktop music player application developed with **C# and Windows Forms**. The application allows users to load multiple audio files, manage them through a playlist, and control their playback using a graphical interface.

The project was developed to practice **C# programming, object-oriented programming, event-driven programming, and Windows Forms development**.

## Features

- Open and load multiple audio files
- Display loaded tracks in a playlist
- Play, pause, and stop audio
- Switch between tracks
- Previous and next track controls
- Restart the current track
- Volume control
- Playback progress bar
- Display the current playback time
- Display track duration
- Graphical user interface built with Windows Forms

## Screenshots

### Main Interface

<img width="386" height="299" alt="Screenshot 2026-08-31 224909" src="https://github.com/user-attachments/assets/186477f1-a696-4b94-87d5-73f7d912a1b5" />

## Technologies

- **C#**
- **.NET Framework 4.8**
- **Windows Forms**
- **Windows Media Player / WMPLib**
- **Object-Oriented Programming**


## Object-Oriented Programming

The project uses basic object-oriented programming concepts through the `Track` class and the `IPlayable` interface.

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

The `Track` class represents an individual audio track and stores information such as:

- Track name
- File path
- Track information

The class implements the `IPlayable` interface and demonstrates the use of classes, properties, constructors, and interfaces.

## How It Works

The user can select multiple audio files through the **Open** button.

The selected files are added to the playlist and can then be selected for playback.

The application uses Windows Media Player through `WMPLib` to handle audio playback.

The Windows Forms interface responds to user interactions such as:

- Button clicks
- Playlist selection
- Volume changes
- Track changes
- Timer updates

A timer is used to update the playback progress and display the current track time.

## Playback Controls

| Control | Function |
|---|---|
| Open | Adds audio files to the playlist |
| Play | Starts playback |
| Pause | Pauses the current track |
| Stop | Stops playback |
| Previous | Moves to the previous track |
| Next | Moves to the next track |
| Restart | Restarts the current track |
| Volume | Controls the playback volume |
| Progress Bar | Displays the current playback position |
| Track Time | Displays playback time and duration |

## Purpose

This project was developed as a practical exercise in **C# and desktop application development**.

The main goals were to practice:

- C# programming fundamentals
- Object-oriented programming
- Classes and objects
- Interfaces
- Encapsulation
- Collections
- Event handling
- Windows Forms
- Working with external components through `WMPLib`

## Future Improvements

Possible improvements include:

- Improved playlist management
- Removing tracks from the playlist
- Shuffle and repeat modes
- Automatic track duration handling
- Displaying album artwork and track metadata
- Improved error handling for missing or unsupported files
- Better separation between the user interface and application logic
- More advanced media controls

## License

This project was created as a learning and portfolio project.

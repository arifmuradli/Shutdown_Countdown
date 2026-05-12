# Shutdown Warning App — Claude Context

## What this project is
A C# Windows Forms app (.NET Framework 4.7.2) that displays a fullscreen-style warning dialog with a 15-minute countdown. If the user does nothing, the computer shuts down. If they click "REJECT", the dialog closes and shutdown is cancelled.

Intended to be deployed/scheduled on idle corporate/lab computers to reclaim unused machines.

## How to run
Open `Final_Project.sln` in **Visual Studio 2019 or later**, then press **F5**.

Requires .NET Framework 4.7.2 (pre-installed on Windows 10/11).

To build from CLI:
```
msbuild Final_Project.sln /p:Configuration=Release
```

Output lands in `bin\Release\Final_Project.exe`.

## Key files
- `Form1.cs` — all runtime logic: countdown tick, shutdown call, reject handler
- `Form1.Designer.cs` — auto-generated UI layout (do not edit by hand)
- `Program.cs` — entry point, launches Form1
- `livech.mp3` — alert sound embedded as a resource, plays on form load
- `codesign_dec.pfx` — code-signing certificate referenced by the `.csproj` (keep locally, never commit)

## Architecture
- Single form (`Form1`) with a `System.Windows.Forms.Timer` ticking every 1000ms
- Countdown label initialized to `15:00`, parsed as MM:SS each tick
- On expiry: `shutdown /s /t 0` via `Process.Start`, then `Environment.Exit(0)`
- REJECT button just calls `this.Close()`
- Form is `TopMost = true` and has no control box (can't be minimized/closed normally)

## Important notes
- The app **will shut down the machine** if the timer runs out — test carefully
- `codesign_dec.pfx` is required for signed builds; if missing, disable assembly signing in project properties before building
- The `.gitignore` excludes `*.pfx` — do not commit certificate files

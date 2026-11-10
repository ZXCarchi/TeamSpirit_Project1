# TeamSpirit — Higher Luck 

Higher Luck is a two-player dice game developed in C# using Windows Forms.

We created this project as part of our university programming course to practise working with classes, events, files, and GitHub as a team of four students.

## Game Rules

1. Both players enter their names and choose different avatars.
2. The number of rounds is selected before starting the game, from 5 to 30.
3. Players take turns rolling a six-sided die.
4. The player with the higher roll earn one point.
5. If both players roll the same number, both of them earn one point.
6. After the final round, the player with the most points wins. Equal scores result in a draw.

## Project Goals

- Player name entry and avatar selection.
- Adjustable number of rounds.
- Turn-based dice rolling.
- Display of scores and the current round.
- Winner and draw announcements.
- Saving completed games to a text file.
- Viewing results from previous sessions.
- Resetting the current game without deleting saved results.

## Technologies

- C#
- Windows Forms
- .NET Framework
- Visual Studio
- Git and GitHub

## Getting Started

### Requirements

- Windows.
- Visual Studio with the .NET desktop development workload.
- The .NET Framework targeting pack required by the project.

## Team Responsibilities

| Member | Responsibilities | Branch |
|---|---|---|
| 1 | Form layout, controls, and interface event handlers | feature/ui |									----78150 Arsen Bektenov
| 2 | Classes, choosen avatar, change name fuction | feature/players |										----78356 Timur Begimkulov
| 3 | Dice rolls, turns, rounds, and score calculation | feature/game |										----78156 Akimov Bektur
| 4 | Saving and loading results, file error handling, testing, and documentation | feature/results |		----78368 Olzhobolotov Akzholtoi

## Working Together

Each team member works in a separate branch and submits changes through a pull request to main.

Before merging, we review the changes and check that the project builds and the affected features work.

Changes to Form1.cs, Form1.Designer.cs, and Form1.resx are coordinated between team members because editing the same form at the same time can cause merge conflicts.

## Testing

Our main checks include:

- Players can not start without completing their setup.
- Players can not choose the same avatar.
- The number of rounds stays between 5 and 30.
- Turns alternate correctly.
- Dice values stay between 1 and 6.
- Points are awarded correctly, including equal rolls.
- The game finishes after the selected number of rounds.
- Each completed game is saved once.
- Saved results remain available after restarting the application.
- Resetting a game does not delete previous results.
- File errors are handled without crashing the application.

## What We Are Learning

Through this project, we are practising:

- Building a Windows Forms interface.
- Separating responsibilities into classes.
- Handling user events.
- Reading and writing text files.
- Handling exceptions.
- Using Git branches and pull requests.
- Testing and combining work as a team.
- Using Git and GitHub.

## Authors

Developed by TeamSpirit for a university programming course.
# MythicArena
FINAL PROJECT
10 distinct commits
Explain project
3 features
Blazor GUI
API (random image)
Database (monsters)
3 methods



EXPLAIN YOUR PROJECT

I had to change from my original idea, but now I have a monster creator. Eventually I would like to add combat, but for now this allows users to store data about the monsters they create. They can store monster stats like Health, Power, and more.

There is also a page I created that displays an image. For now it is just a placeholder. Eventually I would like to make it a monster picture generator so users can get ideas for new monsters, and maybe even assign the image to a monster.



SPECIAL INSTRUCTIONS

This project has two main pages: Monsters and Images. The other pages are from the default project.

Monsters is a page where the user can add a monster to the table. Monster names cannot have numbers. Monster stats must be greater than 0. Then click add monster.

Images is simple, it displays 1 image after hitting the button “load random image”. It will only do this once. If you navigate to a different tab, the image will disappear, but the same image will appear if you hit the button again. The image will only change if you close out all the way and reopen the project.



THREE FEATURES

Implement a regular expression (regex) to validate or ensure a field is always stored and displayed in the correct format (Monsters.razor -> CheckMonsterName method -> starts line 113)

Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program (Monsters.razor -> _monsters list -> AddMonster method -> starts line 127)

Add comments to your code explaining how you are using at least 2 of the solid principles

Fetch.cs in Data folder. Single-responsibility principle: this class is only responsible for fetching the data and putting it in a list

RandomImages.razor in Pages folder. Interface segregation principle: this page and method are separated from the monsters page because it has a separate function. The purpose of this page is to supply the user with an image

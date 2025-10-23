# GameDevelopment
A collection of simple Game-based challenges to explore Development and Deployment patterns

## Mille Bornes
![Front image of the Mille Bornes Card Game Instructions](MilleBornes-Splash.jpg "Mille Bornes")

[© 2009 Hasbro, Pawtucket, RI 02862. All Rights Reserved.](http://hasbrogames.com)

A simple recreation of the Mille Bornes Game written from scratch as a dotNet Solution written mostly in C#.
The goal is to follow development best practices and build this methodically, using it as a real-world training exercise.

[Card Game Instructions](https://instructions.hasbro.com/api/download/17147_en-us_mille-bornes-card-game.pdf)

### Project Objectives
1. Write the core engine for the MILLE BORNES Game.
1. A simple text adventure interface added separately.
1. Explore exposing the text to a webpage based interaction.

### Model Objects

#### Player
* Player Area
* Player Hand []
* Player Score
live auditable computation of current score
* Active Card
the active card is the card you take action with on your turn
#### Player Area
Each stack can be empty and starts that way
* Light Stack []
Green, Red, Hazard, Fix
* Limit Stack []
Limit 50, No limit
* Distance Stack []
25, 50, 75, 100, 200. Visible
* Special Stack []
Ambulance, Ace, Super tires, Jerry can
#### Game Cards
an ordered collection of the cards to be used in the current game
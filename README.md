Old Dungeon
===============

The intention of this project is to create a mix between an old text adventure and an dungeon crawler. 

The core of the game system is wanted to be as agnostic as possible of the underlying infrastructure to be able to play from a console or web app.

The game system is based on a simplified (for the moment) version of the spanish role game [Vieja Escuela (Old School)](http://viejaescuela.nogarung.com/vieja-escuela-el-juego-de-rol/).
Rule book of the game can be found at `./docs/VE_jdr.pdf`.

As paradigm of the code base I'm trying to follow a mix between object and functional oriented programming, using all the functional tool that C# nowadays. <br/>
For the architecture perspective I will use some kind of hexagonal architecture, as mentioned before, to be able to play the game on a console, web, mobile app, ... <br/>
Therefore the three layers will represent:
- Domain (core): Main definition and implementation of the core mechanics and elements of the game.
- Application: Resolution and interaction of the different situations of the game.
- Infrastructure: Implementation of the game in different systems plus other infrastructures like databases and so on.

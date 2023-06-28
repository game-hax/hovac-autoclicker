# hovac autoclicker

**⚠️ WARNING**, in no way is this a representation of my programming abilities. this is not a professional project and i just did this for fun! i might refactor the code and improve it, but for now it works and i dont care enough to change it

## download @ [releases](https://github.com/game-hax/hovac-autoclicker/releases/)!!
> ### version: `4.0.2`

## user interface

its a basic winform interface, you can change the colours in the settings!

![ui screenshot](/assets/ui.png)

## features

this is a basic autoclicker. it offers features such as:
- click sounds
- randomization (bypass any anti-cheat!!)
- support for any game
- extended support for minecraft
  - whitelist slots
  - allow for breaking blocks
  - blockhit mode
  - etc...

it also includes some features that arent in most autoclickers, such as the different modes:
- multi click
  - > multiplys your clicks (1 click = *x* clicks), modifyable multiplier
- autoclicker
  - > classic autoclicker, ive gotten to 300 cps with randomizer disabled
- scroll clicker
  - > scroll up and down = 1 click, scroll quickly for an insane amount of clicks!
- hold clicker
  - > hold mouse down to autoclick, lift mouse up to stop autoclicking!
  - **this is experimental, and sometimes may click while youre not clicking** *(this doesnt affect using "`only in minecraft`")*
- blockhit
  - > 1 left click = 1 right click

## attribution

omg i skidded some stuff 😱😱😱

- [Core/Utils/Cursor.cs](/src/RuntimeBroker/Core/Utils/Cursor.cs): skidded from weynn/Minecraft-Autoclicker, [Sample/Other/CursorVisible.cs](https://github.com/weynn/Minecraft-Autoclicker/blob/main/GithubClicker/GithubClicker/Sample/Other/CursorVisible.cs)
- [Core/Hooks/Keyboard.cs](/src/RuntimeBroker/Core/Hooks/Keyboard.cs): i have no clue where i got this from but i got it years ago and i used it since like 2019 or 2020 or something idk
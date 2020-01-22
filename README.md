This is the .net core version of the smash 64 moveset editor that can run on linux, macos, and windows. Use this if you're not on windows. This requires .net core to be installed. To run this, open a terminal in this folder and run the command "dotnet run"


Welcome to the Smash 64 Moveset Editor from Qapples.

It converts human readable markup code into hex data that can be patched into your Ssb64 game rom. In addition, it will also convert hex data into human readable code (although this will come at a later date)

The markup code is formatted as such:
(OPCODE) (PARAMTERS)
(OPCODE) (PARAMTERS)

Some opcodes have 19 paramters while some have none

Example:
Wait 5
BeginLoop 2
After 3
EndLoop

Here are all avaible commands and their parameters:

Hitbox 
Variables used: ID#1 DMG BKB FKB KBS Angle Bone X Y Z GT AT SD Clang Size Effect SoundType SoundLevel
DMG = Damage of hit
BKB = Base Knockback
FKB = Fixed Knockback
KBS = Knockback Scaling
Angle = the direction that target moves after getting hit
X, Y, & Z are the coordinate offsets of the hitbox location
based on the bone associated with the hitbox
GT = Hits Grounded Targets Flag (0 = off, 1 = on)
AT = Hits Aerial Targets Flag (0 = off, 1 = on)
ID #1 = ID associated with the hitbox
Size = Size of the Hitbox


EndHitboxes
Variables used, None
End Hitboxes simply turns off the hitboxes

ReviveHitbox
Variables used, Main
Revive Hitbox revives the hitboxes after they ended


Wait
Variables used, Main
Wait X means that nothing new happens for X amount of frames


After
Variables used, Main
After X means that nothing new happens until you are on frame X


SFX14
Variables used,Main

SFX19
Variables used,Main

GenVoice (Generic Voice FX)
Variables used, None

Voice (Voice FX)
Variables used, Main

BeginLoop
Variables used, Main
Begin Loop X means that the actions within the loop are
repeated X amount of times


EndLoop
Variables used, None
End Loop is the end of the loop and everything in between
Begin Loop and End Loop are repeated X amount of times


SetFlag
Variables used, Main
Set Flag is the aerial flag and determines fall speed of
certain Up B attacks and auto cancelling.

SetHurtboxState
Variables used, Main
Set Hurtbox State changes the Hurtbox State to X
1 = Vulnerable, 2 = Invincible, 3 = Intangible


ResetHurtboxState
Variables used, Main

SetTextureForm
Variables used, Main

SetSlopeContourState
Variables used, Main

ApplyThrow
Variables used, Main

ThrowData
Variables used, Main
Throw Data is the pointer address for where the throw data is location

CreateProp
Variables used, Main

Goto
Variables used, Main
 
Return
Variables used, None
 
Subroutine
Variables used, Main

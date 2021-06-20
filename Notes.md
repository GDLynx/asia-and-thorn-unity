# Asia & Thorn 

Characters: 
- "corrupted shibas" - half zombie half robotic 
	- these are electrical shiba/dog like creatures 
	- they will gradually gain speed towards you 	
	- if they collide with player, they will give player a "poison" affect 
	- if they are killed, "killed shiba" boolean will become true & player will not be allowed to play as Asia 
- mechanical sharks / "gravity shark" 
	- sharks will accelerate towards the player and remove a large chunk of health on impact 
- mechanical zombie wolf 
	- a mechanical wolf which will accelerate towards you and remove large chunk of health on collision, and give player a poison effect 
	- killing wolf will still allow playing as Asia but will give her a poison effect when you play as her 
- mechanical raptor 
	- killing mechanical raptor will mean Asia cannot phase 
- Shiba lover 
	- name: "Asia"
	- description: "loves shibas, if you kill a shiba she will not help you"

they're may be "breakable floors" which the player can use to return to a lower level using only gravity hammer 

player plays as "Thorn" - a cyborg who weilds a gravity hammer, Thorn cannot jump due to the gravity hammer requiring too much energy, nor can "Asia", but "Asia" can phase - which means to avoid damage for X amount of time , players may swap characters at any time but can only swap 3 times, instead of jumping, players have to traverse the world via teleporters, story & information will be given as speech bubbles above the respective character 

note: not sure if I want the camera to move with the player or there to be many levels 

Not sure if characters (Asia + Thorn) should have their own independent health or a collective health pool 

Should you only get poisoned if you kill a wolf or if you are attacked by a wolf? 

tasks 
- design scenarios 
	- player killed shiba: Asia has speech bubble which will say something along the lines of "ugh, I'm no longer helping you" 
- design & produce character images 
- attempt vital game mechanics using PhaserJS or Unity2D 
- should the player (Thorn) take damage even when they attack? 
	- game mechanics 
		- left + right movement triggered by arrow key respectively - done 
		- collision between player & enemy (wolf/shark/shiba/raptor) 
			- raptor attack 
			- wolf attack 
				- not sure if Asia should only lose health by poison when player is playing as her 
			- shark attack 
			- shiba attack 
		- teleporting 
			- note: for the meantime the teleporters won't actually do anything, basically, anytime a player collides with a teleporter prefab, player's Y axis will be increased by 48 pixels  
			- note: teleporter entrances will be real objects, teleporter exits will be mostly for show 
		- healthbar renered to screen (prefreably above player) 
		- i think only the player should have a trigger coollider 
		- player can attack (only Thorn can attack) 
		- player can swap between Asia & Thorn 
			- image changes 
			- reactions to input changes 
		- camera follows player OR camera gradually rises upwards (even though code may not be used) - failed 
		- Asia phase (does not take damage for 1 seconds) , can only phase twice 
		- player death 


Assets 
- player attack sound effect 
- music 
- Thorn attacking image 
- Asia phasing image 
- Thorn walking image (animation maybe)
- Asia walking image (animation maybe)
- enemy walking image (animation maybe)
- speech bubble image 




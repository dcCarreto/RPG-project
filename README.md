# **Build 0.0.2**
> **Caller.cs**

<br>
<br>
<br>

___

## ***Topics__***
- [Bestiary](#bestiary__)
- [Current creature properties](#current-creature-properties__)
- [Added Symbols for Standardization](#added-symbols-for-standardization__)
- [Current Condition Types](#current-condition-types__)
- [Current Damage Types](#current-damage-types__)
- [Current Range Types](#current-range-types__)
- [Current Creature Proprietary Attack](#current-creature-proprietary-attack__)
- [Creature Attack Function](#creature-attack-function__)
- [Apply Condition Function](#apply-condition-function__)
- [Bestiary List](#bestiary-list__)

___


## ***Bestiary***__
> Bestiary 0 - Complete<br>
> Bestiary 1/8 - Complete<br>
> Bestiary 1/4 - Complete<br>
> Bestiary 1/2 - Complete<br>
> Bestiary 1 - Complete<br>
> Bestiary 2 - Complete<br>
> Bestiary 3 - ***Ongoing...***<br>
> Bestiary 4 - On hold<br>
> Bestiary 5 - On hold<br>
> Bestiary 6 - On hold<br>
> Bestiary 7 - On hold<br>
> Bestiary 8 - On hold<br>
> Bestiary 9 - On hold<br>
> Bestiary 10 - On hold<br>
> Bestiary 11 - On hold<br>
> Bestiary 12 - On hold<br>
> Bestiary 13 - On hold<br>


## ***Current creature properties__***
>|                           |                           |                           |                           |
>|---------------------------|---------------------------|---------------------------|---------------------------|
>| Name                      | Type                      | Size                      | Alignment                 |
>| HitPoints                 | ArmorClass                | Speed                     | Abilities                 |
>| Attributes                | ChallengeLevel            | Experience                | Reactions                 |
>| SavingThrows              | DamageImmunities          | DamageResistances         | Actions                   |
>| DamageVulnerabilities     | ConditionImmunities       | ConditionResistances      |                           |
>| Skills                    | Senses                    | Languages                 |                           |


## ***Added symbols for standardization__***

>## **Sizes**
>> | Size         | Symbol       |
>> |--------------|--------------|
>> | Tiny         |      t       |
>> | Small        |      s       |
>> | Medium       |      m       |
>> | Large        |      l       |
>> | Huge         |      h       |
>> | Gargantuan   |      g       |

>## **Alignments**
>> | Alignment             | Symbol       |
>> |-----------------------|--------------|
>> | Lawful Good           |      lg      |
>> | Neutral Good          |      ng      |
>> | Chaotic Good          |      cg      |
>> | Lawful Neutral        |      ln      |
>> | Neutral               |      n       |
>> | Chaotic Neutral       |      cn      |
>> | Lawful Evil           |      le      |
>> | Neutral Evil          |      ne      |
>> | Chaotic Evil          |      ce      |
>> | Any Alignment         |      aa      |
>> | Unaligned             |      ud      |
>> | Any non-good alignment|     ana      |
>> | Any chaotic alignment |	 aca	  |

>## **Current creature types**
>> | Type                    | Symbol       |
>> |-------------------------|--------------|
>> | Aberration              |      ab      |
>> | Beast                   |      ba      |
>> | Celestial               |      cl      |
>> | Construct               |      co      |
>> | Dragon                  |      dr      |
>> | Elemental               |      el      |
>> | Fey                     |      fy      |
>> | Fiend                   |      fi      |
>> | Giant                   |      gi      |
>> | Humanoid                |      hu      |
>> | Monstrosity             |      mo      |
>> | Ooze                    |      oo      |
>> | Plant                   |      pl      |
>> | Undead                  |      un      |

## ***Current condition types__***
>|  |  |  |  |
>|--|--|--|--|
>| Blinded | Charmed | Deafened | Frightened |
>| Grappled| Incapacitated| Invisible | Paralyzed |
>| Petrified | Poisoned | Prone | Restrained |
>| Stunned | Unconscious | | |

## ***Current damage types__***
>| | | | |
>| -- | -- | -- | -- |
>| Blundgeoning | Piercing | Slashing | Acid |
>| Cold | Fire | Force | Lightning |
>| Necrotic | Poison | Psychic | Radiant |
>| Thunder| | | |  

## ***Current range types__***
>| | |
>|--|--|
>| Melee | Ranged |

## ***Current creature proprietary attack__***
>| | | | |
>|--|--|--|--|
>| Beak | Bite | Claw | Talons |
>| Ram | Rake | Tentacles | |

## ***Creature attack function__***
>- Attack name
>- Damage type
>- Range
>- Damage(dice side)<br>
>***(Usage being AttackList, DamageTypes, RangeTypes, int))***<br>
> **EAttack atk = new();**
> *atk.PerformAttack(AttackList.Beak, DamageTypes.Acid, RangeTypes.Melee, 8)*;
> > - Output: Attack: Beak, Type: Acid, Range: Melee, Attack  Roll - D8: 7


## ***Apply condition function__***
**Ongoing...**

<br>
<br>
<br>

## *Bestiary List__*

| Bestiary CL 0   | Bestiary CL 1/8| Bestiary CL 1/4	   | Bestiary CL 1/2	| Bestiary CL 1			|
|-----------------|----------------|-----------------------|--------------------|-----------------------|
| AwakenedShrub   | Bandit		   | Aarakocra             | Ape				| AnimatedArmor			|
| Baboon          | BloodHawk      | Acolyte               | BlackBear			| BrassDragonWyrmling	|
| Badger          | Camel          | AxeBeak               | Cockatrice			| BrownBear				|
| Bat             | Cultist        | BlinkDog              | Crocodile			| Bugber				|
| Cat             | Flumph         | Boar                  | DarkMantle			| CopperDragonWyrmling	|
| Commoner        | FlyingSnake    | Bullywug              | DustMephit			| DeathDog				|
| Crab            | GiantCrab      | ConstrictorSnake      | GasSpore			| Duergar				|	
| CrawlingClaw    | GiantRat       | DraftHorse            | GiantGoat			| FaerieDragon			|
| Deer            | GiantWeasel    | Dretch                | GiantSeaHorse      | FireSnake				|
| Eagle           | Guard          | Drow                  | GiantWasp			| Ghoul					|
| Frog            | Kobold         | DuoDrone              | Gnoll				| GiantEagle			|
| GiantFireBeetle | Manes          | Elk                   | GrayOoze			| GiantHyena			|
| Goat            | Mastiff        | FlyingSword           | HobGoblin			| GiantOctopus			|
| Hawk            | Merfolk        | GiantBadger           | IceMephit			| GiantSpider			|
| Homunculus      | Monodrone      | GiantBat              | Jackalwere			| GiantToad				|
| Hyena           | Mule           | GiantCentipede        | Lizardfolk			| GiantVulture			|
| Jackal          | Noble          | GiantFrog             | MagmaMephit		| GoblinBoss			|
| Lemure          | PoisonousSnake | GiantLizard           | Magmin				| HalfOgre				|
| Lizard          | Pony           | GiantOwl              | MyconidAdult		| Harpy					|
| MyconidSprout   | SlaadTadpole   | GiantPoisonousSnake   | Orc				| Hippogriff			|
| Octopus         | Stirge         | GiantWolfSpider       | Piercer			| Imp					|
| Owl             | TribalWarrior  | Goblin                | ReefShark			| Quadrone				|
| Quipper         | TwigBlight     | Grimlock              | RustMonster		| QuaggothSporeServant	|
| Rat             | -              | Kenku                 | Sahuagin			| Quasit				| 
| Raven           | -              | KuoToa                | Satyr				| Scarecrow				|
| Scorpion        | -              | MudMephit             | Scout				| Specter				|
| SeaHorse        | -              | NeedleBlight          | Shadow				| Spy					|
| Shrieker        | -              | Panther               | Svifneblin			| ThriKreen				|
| Spider          | -              | Pixie                 | SwarmOfInsects     | Tiger					|
| Vulture         | -              | PseudoDragon          | Thug				| YuanTiPureblood		|
| Weasel          | -              | Pteranodon            | Tridrone			| -						|
| -               | -              | RidingHorse           | VineBlight			| -						|
| -               | -              | Skeleton              | Warhorse			| -						|
| -               | -              | SmokeMephit           | WarhorseSkeleton   | -						|
| -               | -              | Sprite                | Worg				| -						|
| -               | -              | SteamMephit           | -					| -						|
| -               | -              | SwarmOfBats           | -					| -						|
| -               | -              | SwarmOfRats           | -					| -						|
| -               | -              | SwarmOfRavens         | -					| -						|
| -               | -              | Troglodyte            | -					| -						|
| -               | -              | VioletFungus          | -					| -						|
| -               | -              | WingedKobold          | -					| -						|
| -               | -              | Wolf                  | -					| -						|
| -               | -              | Zombie                | -					| -						|

|Bestiary CL 2			|
|-----------------------|
|Allosaurus				|
|Ankheg					|
|AwakanedTree			|
|Azer					|
|BanditCaptain			|
|Berserker				|
|BlackDragonWyrmling	|
|BronzeDragonWyrmling	|
|CarrionCrawler			|
|Centaur				|
|CultistFanatic			|
|Druid					|
|Ettercap				|
|Gargoyle				|
|GelatinousCube			|
|Ghast					|
|GiantBoar				|
|GiantConstrictorSnake	|
|GiantElk				|
|GibberingMouther		|
|GithzeraiMonk			|
|GnollPackLord			|
|GreenDragonWyrmling	|
|Grick					|
|Griffon				|
|HunterShark			|
|IntellectDevourer		|
|LizardfolkShaman		|
|Merrow					|
|Mimic					|
|MinotaurSkeleton		|
|Nothic					|
|OchreJelly				|
|Ogre					|
|Pegasus				|
|Pentadrone				|
|Peryton				|
|Plesiosaurus			|
|PolarBear				|
|Priest					|
|Quaggoth				|
|Rhinoceros				|
|RugOfSmothering		|
|SAberToothedTiger		|
|SahuaginPriestess		|
|SeaHag					|
|SilverDragonWyrmling	|
|SpinedDevil			|
|SwarmOfPoisonousSnakes	|
|Wererat				|
|WhiteDragonWyrmling	|
|WillOWisp				|




# **0.0.2 END**

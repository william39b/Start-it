using Bossfight;

var hero = new GameCharacter("Hero", 100, 20, 40);
var boss = new GameCharacter("Boss", 400, 20, 10);
var fight = new Arena(hero, boss);
fight.Bossfight();
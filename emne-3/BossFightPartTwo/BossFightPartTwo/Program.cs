using BossFightPartTwo;

var hero = new Hero("Hero", 100, 20, 40);
var boss = new Boss("Boss", 400, 20, 10);
var fight = new Arena(hero, boss);
fight.Bossfight();
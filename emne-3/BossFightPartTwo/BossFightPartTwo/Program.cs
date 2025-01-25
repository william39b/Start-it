using BossFightPartTwo;

while (true)
{
    var hero = new Hero("Hero", 100, 30, 40);
    var boss = new Boss("Boss", 400, 30, 10);
    var fight = new Arena(hero, boss);
    fight.BossFight();
}
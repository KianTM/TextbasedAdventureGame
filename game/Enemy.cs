using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Enemy : Creature
    {
        private string enemyType;
        private int worthExp;

        public Enemy(string name, string enemyType, int health, int strength, int defense, int worthExp)
        {
            EnemyType = enemyType;
            WorthExp = worthExp;
        }

        public string EnemyType { get => enemyType; set => enemyType = value; }
        public int WorthExp { get => worthExp; set => worthExp = value; }
    }
}

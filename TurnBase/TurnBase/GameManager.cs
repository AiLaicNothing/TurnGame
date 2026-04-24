using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase
{
    internal class GameManager
    {
        public void Game() 
        {
            Inventario inventory = new Inventario();

            bool gameOver = false;
            while (!gameOver)
            {
                PlayerTurn();
                EnemyTurn();
                CombatResolution();
                CheckeaWin();

            }

        }

        private void PlayerTurn()
        {

        }

        private void EnemyTurn()
        {

        }

        private void CombatResolution()
        {

        }

        private void CheckeaWin()
        {

        }
    }
}

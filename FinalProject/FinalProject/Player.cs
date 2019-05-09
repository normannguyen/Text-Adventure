/* Norman Nguyen
 * 12/13/2018
 * CIS162AD
 * Program: Text Escape: It's a text based adventure game that requires users to put the commands that's given
 * from the game itself. You're tested based on decisions from your actions, some worth it while others not worth the rist.
 * It's the test of trial and error.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        private int health;
        private String command;
        private String name;
        //private int playerdamage = 0;

        public Player(int Hlth, String Nme)
        {
            health = Hlth = 100;
            name = Nme;
        }
        //Health
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        //Command
        public String Command
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
            }
        }
        //Name
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Damage
         {
             get
             {
                 return health;
             }
             set
             {
                 health = health - 10;
             }
         }
        public int Damage2
        {
            get
            {
                return health;
            }
            set
            {
                health = health - 20;
            }
        }
    }
}

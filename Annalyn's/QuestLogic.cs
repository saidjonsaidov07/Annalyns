using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annalyn_s
{
    internal class QuestLogic
    {
        public static bool CanFastAttack(bool result)
        {
            bool answer;
            if (result == true)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }
        public static bool CanSpy(bool knight, bool ancher, bool prisoner) 
        {
            bool result;
            if (knight == true || ancher == true || prisoner == true) 
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public static bool CanSignalPrisoner(bool inner1, bool inner2)
        {
            bool result;
            if (inner1 == false || inner2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CanFreePrisoner(bool knight, bool archer, bool prisoner, bool petDog)
        {
            if(knight == true && archer == true && prisoner == true && petDog == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

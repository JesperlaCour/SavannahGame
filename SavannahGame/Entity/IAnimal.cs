using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    interface IAnimal
    {
        void Move();
        void Die();
        void Eat(int x);
        void CheckWeight();
        void ChangeWeight(int y);


       
    }
}

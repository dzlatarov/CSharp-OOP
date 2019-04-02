using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Contracts
{
    public interface ITarget
    {
        int Health { get; }

        void TakeAttack(int damage);

        bool IsDead();

        int GiveExperience();
    }
}

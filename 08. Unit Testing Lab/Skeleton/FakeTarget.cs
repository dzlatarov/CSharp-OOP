﻿using Skeleton.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public class FakeTarget : ITarget
    {
        public int Health { get; private set; } = 0;

        public int GiveExperience()
        {
            return 10;
        }

        public bool IsDead()
        {
            return this.Health <= 0;
        }

        public void TakeAttack(int damage)
        {
            this.Health -= damage;
        }
    }
}

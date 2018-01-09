﻿using System;

namespace BlockChain.Models
{
    public class Wallet
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

﻿using DiamonShop.Core.Repository;

namespace DiamonShop.Core.SeedWorks
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IDiamondRepository Diamond { get; }
        Task<int> Save();

    }
}
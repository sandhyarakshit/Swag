using EnergyConsumption.Interfaces;
using EnergyConsumption.Models;
using System;

namespace EnergyConsumption.Repository
{
    public class EnergyRepository : IEnergyRepository
    {
        private readonly EnergyDbContext _dbContext;

        public EnergyRepository(EnergyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<EnergyData> GetAll()
        {
            // Implement logic to fetch all energy data from the database
            // Example:
            return _dbContext.EnergyDatas.ToList();
        }

        public EnergyData GetById(int id)
        {
            // Implement logic to fetch energy data by id from the database
            // Example:
            return _dbContext.EnergyDatas.FirstOrDefault(e => e.UserID == id);
        }

        public void Create(EnergyData energyData)
        {
            // Implement logic to add energy data to the database
            // Example:
            _dbContext.EnergyDatas.Add(energyData);
            _dbContext.SaveChanges();
        }

        public void Update(EnergyData energyData)
        {
            // Implement logic to update energy data in the database
            // Example:
            _dbContext.EnergyDatas.Update(energyData);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            // Implement logic to delete energy data from the database
            // Example:
            var energyData = _dbContext.EnergyDatas.FirstOrDefault(e => e.UserID == id);
            if (energyData != null)
            {
                _dbContext.EnergyDatas.Remove(energyData);
                _dbContext.SaveChanges();
            }
        }
    }
}


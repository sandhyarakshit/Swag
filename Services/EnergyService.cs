﻿using EnergyConsumption.Interfaces;
using EnergyConsumption.Models;

namespace EnergyConsumption.Services
{
    public class EnergyService
    {
        private readonly IEnergyRepository _energyRepository;

        public EnergyService(IEnergyRepository energyRepository)
        {
            _energyRepository = energyRepository;
        }

        public IEnumerable<EnergyData> GetAllEnergyData()
        {
            return _energyRepository.GetAll();
        }

        public EnergyData GetEnergyDataById(int id)
        {
            return _energyRepository.GetById(id);
        }

        public void CreateEnergyData(EnergyData energyData)
        {
            _energyRepository.Create(energyData);
        }

        public void UpdateEnergyData(EnergyData energyData)
        {
            _energyRepository.Update(energyData);
        }

        public void DeleteEnergyData(int id)
        {
            _energyRepository.Delete(id);
        }
    }
}

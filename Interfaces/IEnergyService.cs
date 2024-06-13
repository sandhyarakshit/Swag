using EnergyConsumption.Models;

namespace EnergyConsumption.Interfaces
{
    public interface IEnergyService
    {
        IEnumerable<EnergyData> GetAllEnergyData();
        EnergyData GetEnergyDataById(int id);
        void CreateEnergyData(EnergyData energyData);
        void UpdateEnergyData(EnergyData energyData);
        void DeleteEnergyData(int id);
    }
}

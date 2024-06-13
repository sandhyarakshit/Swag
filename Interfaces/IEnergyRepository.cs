using EnergyConsumption.Models;

namespace EnergyConsumption.Interfaces
{
    public interface IEnergyRepository
    {
        IEnumerable<EnergyData> GetAll();
        public  EnergyData GetById(int id);
       public  void Create(EnergyData energyData);
        void Update(EnergyData energyData);
        void Delete(int id);
    }
}

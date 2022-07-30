using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public interface ITransmissionRepository
    {
        void Add(TransmissionModel transmissionModel);
        void Update(TransmissionModel transmissionModel);
        void Delete(int id);
        IEnumerable<TransmissionModel> GetAll();
        IEnumerable<TransmissionModel> GetByValue(string value);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DataLayer.Models;
using TMS.ViewModels;

namespace TMS.DataLayer.Repositories
{
    public interface IClothRepository
    {
        List<Cloth> GetAllCloths();
        IEnumerable<Cloth> GetClothByFilter(string parameter);
        Cloth GetClothById(int clothId);
        string GetClothNameById(int clothId);
        long GetClothIdByName(string name);
        bool InsertCloth(Cloth cloth);
        bool UpdateCloth(Cloth cloth);
        bool DeleteCloth(Cloth cloth);
        bool DeleteCloth(int clothId);
    }
}

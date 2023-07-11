using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TMS.DataLayer.Models;
using TMS.DataLayer.Repositories;
using TMS.ViewModels;

namespace TMS.DataLayer.Services
{
    public class ClothRepository : IClothRepository
    {
        private AppDbContext _db;

        public ClothRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Cloth> GetAllCloths()
        {
            return _db.Cloths.ToList();
        }
        public Cloth GetClothById(int clothId)
        {
            return _db.Cloths.Find(clothId);
        }
        public IEnumerable<Cloth> GetClothByFilter(string parameter)
        {
            return _db.Cloths.Where(c => c.ClothName.Contains(parameter) || c.ClothCode.Contains(parameter)).ToList();
        }
        public string GetClothNameById(int clothId)
        {
            return _db.Cloths.Find(clothId).ClothName;
        }
        public long GetClothIdByName(string name)
        {
            return _db.Cloths.First(c => c.ClothName == name).Id;
        }
        public bool InsertCloth(Cloth cloth)
        {
            try
            {
                _db.Cloths.Add(cloth);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCloth(Cloth cloth)
        {
            var local = _db.Set<Cloth>()
                .Local
                .FirstOrDefault(f => f.Id == cloth.Id);
            if (local != null)
            {
                _db.Entry(local).State = EntityState.Detached;
            }
            _db.Entry(cloth).State = EntityState.Modified;
            return true;
        }
        public bool DeleteCloth(Cloth cloth)
        {
            try
            {
                _db.Entry(cloth).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCloth(int clothId)
        {
            try
            {
                var cloth = GetClothById(clothId);
                DeleteCloth(cloth);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

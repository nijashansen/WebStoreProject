using System.Linq;
using Core.DomainServices;
using Core.DomainServices.Filtering;
using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SQLList.Repository
{
    public class ClothingRepository: IClothingRepository
    {
        private Context _context;
        
        public FilteringList<Clothing> ReadClothingList(Filter filter = null)
        {
            var filteredList = new FilteringList<Clothing>();

            if (filter != null && filter.CurrentPage > 0 && filter.InfoPrPage > 0)
            {
                filteredList.List = _context.Clothes
                    .Skip((filter.CurrentPage - 1) * filter.InfoPrPage)
                    .Take(filter.InfoPrPage)
                    .ToList();
                return filteredList;
            }

            filteredList.List = _context.Clothes;
            
            filteredList.Count = filteredList.List.Count();
            return filteredList;
        }

        public Clothing CreateClothing(Clothing clothing)
        {
            if(clothing != null)
            {
                _context.Attach(clothing).State = EntityState.Added;
            }
            var clothingSaved = _context.Clothes.Add(clothing).Entity;
            _context.SaveChanges();
            return clothingSaved;
        }

        public Clothing DeleteClothing(int id)
        {
            var entityRemoved = _context.Remove(new Clothing { Id = id }).Entity;
            _context.SaveChanges();
            return entityRemoved;
        }

        public Clothing UpdateClothing(Clothing clothingToUpdate)
        {
            if (clothingToUpdate != null)
            {
                _context.Attach(clothingToUpdate).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return clothingToUpdate;
        }

        public Clothing readClothing(int id)
        {
            return _context.Clothes
                .FirstOrDefault(c => c.Id == id);
        }
    }
}
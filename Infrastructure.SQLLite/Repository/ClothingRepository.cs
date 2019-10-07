using Core.DomainServices;
using Core.DomainServices.Filtering;
using Core.Entity;

namespace Infrastructure.SQLList.Repository
{
    public class ClothingRepository: IClothingRepository
    {
        public FilteringList<Clothing> ReadClothingList(Filter filter = null)
        {
            throw new System.NotImplementedException();
        }

        public Clothing CreateClothing(Clothing clothing)
        {
            throw new System.NotImplementedException();
        }

        public Clothing DeleteClothing(int id)
        {
            throw new System.NotImplementedException();
        }

        public Clothing UpdateClothing(Clothing clothingToUpdate)
        {
            throw new System.NotImplementedException();
        }

        public Clothing readClothing(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
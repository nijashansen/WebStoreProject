using Core.DomainServices.Filtering;
using Core.Entity;

namespace Core.DomainServices
{
    public interface IClothingRepository
    {
        FilteringList<Clothing> ReadClothingList(Filter filter = null);
        Clothing CreateClothing(Clothing clothing);
        Clothing DeleteClothing(int id);
        Clothing UpdateClothing(Clothing clothingToUpdate);
        Clothing readClothing(int id);
    }
}
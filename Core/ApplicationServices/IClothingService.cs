using Core.DomainServices.Filtering;
using Core.Entity;

namespace Core.ApplicationServices
{
    public interface IClothingService
    {
        Clothing CreateClothing(Clothing clothing);
        Clothing ReadClothing(int id);
        Clothing UpdateClothing(Clothing clothingToUpdate);
        Clothing DeleteClothing(int id);
        FilteringList<Clothing> ReadAllClothes(Filter filter);
    }
}
using Core.DomainServices;
using Core.DomainServices.Filtering;
using Core.Entity;

namespace Core.ApplicationServices.Impl
{
    public class ClothingService: IClothingService
    {
        private readonly IClothingRepository _clothRepo;

        public ClothingService(IClothingRepository clothingRepository)
        {
            _clothRepo = clothingRepository;
        }
        
        public Clothing CreateClothing(Clothing clothing)
        {
            return _clothRepo.CreateClothing(clothing);
        }

        public Clothing ReadClothing(int id)
        {
            return _clothRepo.readClothing(id);
        }

        public Clothing UpdateClothing(Clothing clothingToUpdate)
        {
            return _clothRepo.UpdateClothing(clothingToUpdate);
        }

        public Clothing DeleteClothing(int id)
        {
            return _clothRepo.DeleteClothing(id);
        }

        public FilteringList<Clothing> ReadAllClothes(Filter filter)
        {
            return _clothRepo.ReadClothingList(filter);
        }
    }
}
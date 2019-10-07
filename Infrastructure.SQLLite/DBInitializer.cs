using Core.Entity;

namespace Infrastructure.SQLList
{
    public class DBInitializer
    {
        public static void Initialize(Context context)
        {
            Clothing clothing1 = new Clothing
            {
                ClothesTypes = ClothesTypes.TShirt,
                ClothingName = "Gucci",
                Size = "L"
            };
            
            Clothing clothing2 = new Clothing
            {
                ClothesTypes = ClothesTypes.Pants,
                ClothingName = "Adidas",
                Size = "XS"
            };
            
            Clothing clothing3 = new Clothing
            {
                ClothesTypes = ClothesTypes.Hoodie,
                ClothingName = "Totoro",
                Size = "XL"
            };
            
            Clothing clothing4 = new Clothing
            {
                ClothesTypes = ClothesTypes.Dress,
                ClothingName = "Pieces",
                Size = "M"
            };
            
            Clothing clothing5 = new Clothing
            {
                ClothesTypes = ClothesTypes.Shoes,
                ClothingName = "Jordans",
                Size = "42"
            };
            
            Clothing clothing6 = new Clothing
            {
                ClothesTypes = ClothesTypes.Skirt,
                ClothingName = "Only",
                Size = "XXXXXXL"
            };
            
            Clothing clothing7 = new Clothing
            {
                ClothesTypes = ClothesTypes.TShirt,
                ClothingName = "Nike",
                Size = "XL"
            };
            
            Clothing clothing8 = new Clothing
            {
                ClothesTypes = ClothesTypes.Pants,
                ClothingName = "Hummel",
                Size = "XS"
            };


            clothing1 = context.Clothes.Add(clothing1).Entity;
            clothing2 = context.Clothes.Add(clothing2).Entity;
            clothing3 = context.Clothes.Add(clothing3).Entity;
            clothing4 = context.Clothes.Add(clothing4).Entity;
            clothing5 = context.Clothes.Add(clothing5).Entity;
            clothing6 = context.Clothes.Add(clothing6).Entity;
            clothing7 = context.Clothes.Add(clothing7).Entity;
            clothing8 = context.Clothes.Add(clothing8).Entity;


            context.SaveChanges();
        }  
    }
}
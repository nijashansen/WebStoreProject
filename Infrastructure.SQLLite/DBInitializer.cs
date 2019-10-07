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
                Size = "L",
                Price = 699
            };
            
            Clothing clothing2 = new Clothing
            {
                ClothesTypes = ClothesTypes.Pants,
                ClothingName = "Adidas",
                Size = "XS",
                Price = 499
            };
            
            Clothing clothing3 = new Clothing
            {
                ClothesTypes = ClothesTypes.Hoodie,
                ClothingName = "Totoro",
                Size = "XL",
                Price = 199
            };
            
            Clothing clothing4 = new Clothing
            {
                ClothesTypes = ClothesTypes.Dress,
                ClothingName = "Pieces",
                Size = "M",
                Price = 599
            };
            
            Clothing clothing5 = new Clothing
            {
                ClothesTypes = ClothesTypes.Shoes,
                ClothingName = "Jordans",
                Size = "42",
                Price = 349
            };
            
            Clothing clothing6 = new Clothing
            {
                ClothesTypes = ClothesTypes.Skirt,
                ClothingName = "Only",
                Size = "XXXXXXL",
                Price = 799
            };
            
            Clothing clothing7 = new Clothing
            {
                ClothesTypes = ClothesTypes.TShirt,
                ClothingName = "Nike",
                Size = "XL",
                Price = 999
            };
            
            Clothing clothing8 = new Clothing
            {
                ClothesTypes = ClothesTypes.Pants,
                ClothingName = "Hummel",
                Size = "XS",
                Price = 99
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
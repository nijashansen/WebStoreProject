using Core.Entity;

namespace Infrastructure.SQLList
{
    public class DBInitializer
    {
        public static void Initialize(Context ctx)
        {
            Clothing clothing1 = new Clothing
            {
                ClothingType = "TShirt",
                ClothingName = "Gucci",
                Size = "L",
                Price = 699
            };
            
            Clothing clothing2 = new Clothing
            {
                ClothingType = "Pants",
                ClothingName = "Adidas",
                Size = "XS",
                Price = 499
            };
            
            Clothing clothing3 = new Clothing
            {
                ClothingType = "Hoodie",
                ClothingName = "Totoro",
                Size = "XL",
                Price = 199
            };
            
            Clothing clothing4 = new Clothing
            {
                ClothingType = "Dress",
                ClothingName = "Pieces",
                Size = "M",
                Price = 599
            };
            
            Clothing clothing5 = new Clothing
            {
                ClothingType = "Shoes",
                ClothingName = "Jordans",
                Size = "42",
                Price = 349
            };
            
            Clothing clothing6 = new Clothing
            {
                ClothingType = "Skirt",
                ClothingName = "Only",
                Size = "XXXXXXL",
                Price = 799
            };
            
            Clothing clothing7 = new Clothing
            {
                ClothingType = "TShirt",
                ClothingName = "Nike",
                Size = "XL",
                Price = 999
            };
            
            Clothing clothing8 = new Clothing
            {
                ClothingType = "Pants",
                ClothingName = "Hummel",
                Size = "XS",
                Price = 99
            };


            clothing1 = ctx.Clothes.Add(clothing1).Entity;
            clothing2 = ctx.Clothes.Add(clothing2).Entity;
            clothing3 = ctx.Clothes.Add(clothing3).Entity;
            clothing4 = ctx.Clothes.Add(clothing4).Entity;
            clothing5 = ctx.Clothes.Add(clothing5).Entity;
            clothing6 = ctx.Clothes.Add(clothing6).Entity;
            clothing7 = ctx.Clothes.Add(clothing7).Entity;
            clothing8 = ctx.Clothes.Add(clothing8).Entity;


            ctx.SaveChanges();
        }  
    }
}
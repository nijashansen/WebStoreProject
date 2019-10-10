using Core.Entity;

namespace Infrastructure.SQLList
{
    public class DBInitializer
    {
        public static void Initialize(Context ctx)
        {
            Clothing clothing1 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Chanel, Made for Lars",
                Size = "OneSize",
                Price = 18999,
                ClothingInformation = "Online since: 10/10/2019\n "
                + "Categories : Women\n "
                + "Category: Bags\n "
                + "Sub-category: Handbags\n "
                + "Designer: Chanel\n " 
                + "Model: Made for Lars\n "
                + "Condition: Good condition\n "
                + "Material: Leather\n "
                + "Colour: Black\n "
                + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8400048-1_1.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };

            Clothing clothing2 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Gucci, Dionysus",
                Size = "OneSize",
                Price = 8299,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Gucci\n " 
                                      + "Model: Dionysus\n "
                                      + "Condition: Good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Black\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8392324-1_1.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };
            
            Clothing clothing3 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Marmont, Velvet Handbag",
                Size = "OneSize",
                Price = 8199,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Chanel\n " 
                                      + "Model: Marmont\n "
                                      + "Condition: Very good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Black\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8395767-1_2.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };

            Clothing clothing4 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Chanel, Classic Flap Bag",
                Size = "OneSize",
                Price = 14499,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Chanel\n " 
                                      + "Model: Classic Flip Bag\n "
                                      + "Condition: Very good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Black\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8396923-1_1.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };

            Clothing clothing5 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Marmont, Velvet Handbag",
                Size = "OneSize",
                Price = 6999,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Chanel\n " 
                                      + "Model: Marmont\n "
                                      + "Condition: Very good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Pink\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8397979-1_1.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };
            
            Clothing clothing6 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Chanel, Kristian's Passion",
                Size = "OneSize",
                Price = 16999,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Chanel\n " 
                                      + "Model: Kristian's Passion'\n "
                                      + "Condition: Good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Pink\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8362206-1_2.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };

            Clothing clothing7 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Chloé, Faye",
                Size = "OneSize",
                Price = 3499,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Chloé\n " 
                                      + "Model: Faye\n "
                                      + "Condition: Very good condition\n "
                                      + "Material: Leather\n "
                                      + "Colour: Blue\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8407849-1_1.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
            };
            
            Clothing clothing8 = new Clothing
            {
                ClothingType = "Bag",
                ClothingName = "Maddelena Marconi",
                Size = "OneSize",
                Price = 14499,
                ClothingInformation = "Online since: 10/10/2019\n "
                                      + "Categories : Women\n "
                                      + "Category: Bags\n "
                                      + "Sub-category: Handbags\n "
                                      + "Designer: Maddelena Marconi\n " 
                                      + "Model: Silk Clutch Bag\n "
                                      + "Condition: Very good condition\n "
                                      + "Material: Silk\n "
                                      + "Colour: Beige\n "
                                      + "Style:Vintage",
                ImgLink = "https://vestiairecollective.imgix.net/produit/8403547-1_2.jpg?&w=224&h=224&auto=compress&fm=pjpg&ch=DPR&dpr=2&fit=crop"
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
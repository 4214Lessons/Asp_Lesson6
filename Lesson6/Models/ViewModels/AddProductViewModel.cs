using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models.ViewModels
{
    public class AddProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        //public static explicit operator Product(AddProductViewModel model)
        //{
        //    return new Product()
        //    {
        //        Name = model.Name,
        //        Description = model.Description,
        //        Price = model.Price,
        //        Quantity = model.Quantity,
        //        Rating = 0,
        //        Id = 1
        //    };
        //}

        //public static explicit operator AddProductViewModel(Product model)
        //{
        //    return new AddProductViewModel()
        //    {
        //        Name = model.Name,
        //        Description = model.Description,
        //        Price = model.Price,
        //        Quantity = model.Quantity,
        //    };
        //}

        public static implicit operator Product(AddProductViewModel model)
        {
            return new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Quantity = model.Quantity,
                Rating = 0,
                Id = 1
            };
        }

        public static implicit operator AddProductViewModel(Product model)
        {
            return new AddProductViewModel()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Quantity = model.Quantity,
            };
        }
    }
}

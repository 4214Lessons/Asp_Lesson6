using Lesson6.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lesson6.Models
{
    //[ModelMetadataType(typeof(UserValidator))]
    public class User
    {
        public string Email { get; set; }

        public int Age { get; set; }

        public double Rating { get; set; }
    }
}

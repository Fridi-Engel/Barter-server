using System;
using System.Collections.Generic;
using DTO;
using DAL;

namespace BL
{
    public class CategoriesBL
    {
        public IEnumerable<CategoriesDTO> GetCategories()
        {
           var categoriesList=new CategoriesDAL().GetCategories();
            foreach (var item in categoriesList)
            {
                yield return Converters.Converter.ConvertToDTO<Categories, CategoriesDTO>(item);
            }
        }
    }
}
using CarvedRock.Api.Data;
using CarvedRock.Api.Repositories;
using CarvedRock.Api.GraphQL.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<CarvedRock.Api.GraphQL.Types.ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
                );
            //Field<ListGraphType<ProductType>>(
            //    "products",
            //    resolve: context => productRepository.GetAll()
            //    );
        }
    }
}

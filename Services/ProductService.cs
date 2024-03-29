﻿using Microsoft.Extensions.WebEncoders.Testing;
using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService
	{
        private readonly TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
        }

		public ProductList ListProducts(int page)
		{
			return new ProductList() {  HasNext=false, TotalCount =10, Products = _ctx.Products.ToList().GetRange((page - 1)*10,10)};
		}

	}
}

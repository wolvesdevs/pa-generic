﻿using Generic.Domain.Entities;

namespace Generic.Infrastructure.Csv.ForAbstractClass;

public class ProductCsv1
{

}

//public class ProductCsv1 : CsvBase<ProductEntity>
//{
//    public override ProductEntity GetEntity(string[] items)
//    {
//        return new ProductEntity(Convert.ToInt32(items[0]), items[1], Convert.ToInt32(items[2]));
//    }

//    public override int GetItemLength()
//    {
//        return 3;
//    }

//    public override string GetPath()
//    {
//        return "Product.csv";
//    }
//}

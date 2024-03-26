﻿using Generic.Domain.Exceptions;
using Generic.Domain.Repositories;

namespace Generic.Infrastructure.Csv;

public abstract class CsvBase<T> where T : IEntity
{
    public abstract string FilePath { get; }
    public abstract int ItemCount { get; }

    public IEnumerable<T> GetAll()
    {
        var lines = File.ReadAllLines(FilePath);
        bool isFirst = true;
        List<T> entities = new();

        foreach (var line in lines)
        {
            if (isFirst)
            {
                isFirst = false;
                continue;
            }

            var items = line.Split(',');
            if (items.Length != ItemCount)
            {
                throw new CsvException("ファイルフォーマットが無効です。");
            }

            var product = GetEntity(items);
            
            entities.Add(product);
        }

        return entities;
    }

    public abstract T GetEntity(string[] items);
}

//public abstract class CsvBase<T> where T : IEntity
//{
//    public abstract string FilePath { get; }
//    public abstract int ItemCount { get; }

//    public IEnumerable<T> GetAll()
//    {
//        var lines = File.ReadAllLines(FilePath);
//        bool isFirst = true;
//        List<T> entities = [];

//        foreach (var line in lines)
//        {
//            if (isFirst)
//            {
//                isFirst = false;
//                continue;
//            }

//            var items = line.Split(',');
//            if (items.Length != ItemCount)
//            {
//                throw new CsvException();
//            }

//            var entity = GetEntity(items);

//            entities.Add(entity);
//        }

//        return entities;
//    }

//    public abstract T GetEntity(string[] items);
//}

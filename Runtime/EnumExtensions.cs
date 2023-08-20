using System;
using System.Collections.Generic;

public class EnumExtensions
{
    public static IEnumerable<T> GetAllItems<T>() where T : Enum
    {
        foreach (var item in Enum.GetValues(typeof(T)))
        {
            yield return (T)item;
        }
    }
}
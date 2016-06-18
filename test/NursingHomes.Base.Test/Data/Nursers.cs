using System;
using System.Collections.Generic;
using NursingHomes.Base.Domain;

namespace NursingHomes.Base.Test.Data
{
    public class Nursers
    {
        public static List<Nurser> NurserList()
        {
            return new List<Nurser>()
            {
                new Nurser() { Id =new Guid("4408296A-7C3B-4D44-A34F-7B5B6A4AE071"),Name = "张三1"},
                new Nurser() { Id =new Guid("CE8307F4-B962-4B22-87DE-1C99A6C2F308"),Name = "张三2"},
                new Nurser() { Id =new Guid("392FB1D2-77C7-4961-8FFA-47ADFDF45DE4"),Name = "张三3"},
                new Nurser() { Id =new Guid("C9B85DD0-7037-4609-B93D-59B447CADCC0"),Name = "张三4"},
            };
        }
    }
}

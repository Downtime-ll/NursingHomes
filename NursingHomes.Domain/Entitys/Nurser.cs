using System;

namespace NursingHomes.Domain.Entitys
{
    public class Nurser {
    public Guid Id{get;set;}
    public string Name {get;set;}
    public stirng NurserNo{get;set;}
    public Sex Sex{get;set;}
    public string Info{get;set}
    public Datetime BirthDay{get;set;}
    public int WorkYear{get;set;}
    
    public string Remark{get;set;}
    
    }
    
    public class NurserUser
    {
        public Guid UserId{get;set;}
        public Guid NurserId{get;set;}
        
        
    }
    
}


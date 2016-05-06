using System;

public class User{
   public Guid Id{get;set;}
   public string Name{get;set;}
   public DateTime BirthDay{get;set;}
   public Sex Sex{get;set;}
   public string Address{get;set;}
   public string Tel{get;set;}
   public stirng MedicalHistory{get;set;}
   public string RoomNo{get;set;}
   
   public string Remerk{get;set;}
   public IList<HomePeople> HomePeople{get;set;}
   
}

public class HomePeople{
    public Guid Id{get;set;}
    public string Name{get;set;}
    
    public relationType RelationType{get;set;}
    public Sex Sex{get;set;}
    public string Address{get;set;}
    public string Tel {get;set;}
    public string Work{get;set;}
    
}
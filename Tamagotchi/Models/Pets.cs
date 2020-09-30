using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{

  public class Pet
  {

    public string Name { get; set; }
    public string Image { get; set; }
    public int Id { get; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    private static List<Pet> _instances = new List<Pet> { };


    public Pet(string name, string image)
    {
      Name = name;
      Image = image;
      Food = 50;
      Attention = 50;
      Rest = 50;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void Feed()
    {
      TimePass();
      this.Food += 25;
    }

    public void Play()
    {
      TimePass();
      this.Attention += 25;
    }

    public void Sleep()
    {
      TimePass();
      this.Rest += 50;
    }
    public static List<Pet> GetAll()
    {
      Console.WriteLine();
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public static void TimePass()
    {
      // List<Pet> petList = GetAll();
      foreach (Pet pet in _instances)
      {
        pet.Food -= 5;
        pet.Attention -= 5;
        pet.Rest -= 5;
      }
    }
  }
}
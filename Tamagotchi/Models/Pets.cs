using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{

  public class Pet
  {
    private List<Pets> _instances = new List<Pets> { };
    public string Name { get; set; }

    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }


    public Pet(string name)
    {
      Name = name;
      Food = 50;
      Attention = 50;
      Rest = 50;
      _instances.Add(this);
    }

    public Feed()
    {
      this.Food += 10;
    }

    public Play()
    {
      this.Attention += 10;
    }

    public Sleep()
    {
      this.Rest += 50;
    }
  }
}
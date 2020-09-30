using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }

    [TestMethod]
    public void Pet_InstantiateAnInstanceOfPet_Pet()
    {
      Pet bob = new Pet("test");
      Assert.AreEqual(typeof(Pet), bob.GetType());
    }
    [TestMethod]
    public void Pet_InstantiateAnInstanceOfPet_newPet()
    {
      //Arrange
      string name = "Bob";
      //Act
      Pet newPet = new Pet(name);
      string result = newPet.Name;
      // Assert
      Assert.AreEqual("Bob", result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PetList()
    {
      // Arrange
      List<Pet> newList = new List<Pet> { };

      // Act
      List<Pet> result = Pet.GetAll();


      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsListOfItems_PetList()
    {
      // Arrange
      string petName1 = "Bob";
      string petName2 = "Fluffy";
      Pet newPet1 = new Pet(petName1);
      Pet newPet2 = new Pet(petName2);
      List<Pet> newList3 = new List<Pet> { newPet1, newPet2 };

      // Act
      List<Pet> result = Pet.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList3, result);
    }

    [TestMethod]
    public void Find_FindItemsInList_Pet()
    {
      // Arrange
      string petName1 = "Bob";
      string petName2 = "Fluffy";
      Pet newPet1 = new Pet(petName1);
      Pet newPet2 = new Pet(petName2);
      List<Pet> newList3 = new List<Pet> { newPet1, newPet2 };

      // Act
      Pet result = Pet.Find(2);

      // Assert
      Assert.AreEqual(newPet2, result);
    }
  }
}
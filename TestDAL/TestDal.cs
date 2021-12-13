using System.Collections.Generic;
using DAL;
using DTO;
using NUnit.Framework;

namespace TestDAL;

public class TestsDal
{
    private readonly DalManager _dalManager = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestInsert()
    {
        _dalManager.InsertMovie(new MovieDTO(1, "Démo", new List<ActorDTO>()));
        Assert.Pass();
    }
}
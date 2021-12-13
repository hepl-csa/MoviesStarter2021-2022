using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using DTO;
using NUnit.Framework;

namespace TestBLL;

public class Tests
{
    private BLLManager _bllManager = new();

    [SetUp]
    public void Setup()
    {
        
    }
    

    [Test]
    public void TestInserting()
    {
        int randomValue = new Random().Next();
        MovieDTO movieDto = new MovieDTO(randomValue.ToString(), new List<ActorDTO>());
        _bllManager.InsertMovie(movieDto);
        if (_bllManager.GetMovie(movie => movie.Title.Equals(randomValue.ToString())) != null)
        {
            Assert.Pass();
        }
        else
        {
            Assert.Fail();
        }
    }
}
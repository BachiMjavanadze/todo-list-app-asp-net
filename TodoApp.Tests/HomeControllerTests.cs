using NUnit.Framework;
using System;
using System.Collections.Generic;
using TodoApp.Controllers;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Tests;

[TestFixture]
public class HomeControllerTests
{
    [TestCase(null)]
    public void ReturnView_NullParameter_Throws(IEnumerable<Todo> objTodoList)
    {
        Assert.Throws<ArgumentNullException>(() => new HomeController(new ApplicationDbContext()).ReturnView(objTodoList));
    }
}
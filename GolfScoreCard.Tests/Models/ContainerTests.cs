using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GolfScoreCard.Models;
using System.Collections.Generic;

namespace GolfScoreCard.Tests.Models
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void ContainerEnsureICanCreateInstance()
        {
            Container container = new Container();
            Assert.IsNotNull(container);
        }

        [TestMethod]
        public void ContainerEnsureContainerPropertiesWork()
        {
            Container container = new Container { Title = "My Container" };

            GolfCourseList golfcourse_list = new GolfCourseList { Title = "My Golf Course" };
            container.Lists.Add(golfcourse_list);

            ApplicationUser a_user = new ApplicationUser();
            container.Followers.Add(a_user);

            Assert.AreEqual("My Container", container.Title);
            Assert.AreEqual(1, container.Lists.Count);
            Assert.AreEqual(1, container.Followers.Count);
        }
    }
}

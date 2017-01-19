using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAPP.Test;
using ConsoleApplication1;

namespace ConsoleAPP.Test
{
    [TestClass]
    class Vehicle
    {
        Vehicle v;
        IVehicle iVehicle;
        Mock<IVehicle> mock;
        Driver D;
        [TestInitialize]
        public void Initialize()
        {
            v = new Vehicle();
          
        }


        [TestMethod]
        public void Check_Vehicle_Manuvers()
        {
            //Arrange 
            mock.Setup(x => x.ApplyBrakes()).Returns(true);
            D = new Driver(mock.Object);

            //Act
            bool res = D.Manuveurvehicle(false);

            //Assert
            Assert.IsTrue(res);
            mock.Verify(x => x.ApplyBrakes(), Times.Never());
            mock.Verify(x => x.HonkHorn(), Times.Once());

        }
    }
}

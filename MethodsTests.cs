using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Tests
{
	public class MethodsTests
	{
		[TestMethod()]
		public void CreateBoardTest()
		{
			var methods = new Methods();
			var result = methods.CreateBoard();
			Assert.AreEqual(9, result); //result should be equal to 9
		}

		[TestMethod()]
		public void CurrentPlayerTest()
		{
			var methods = new Methods();
			var result = methods.CurrentPlayer();
			Assert.AreEqual('X', result);
		}

		[TestMethod()]
		public void CurrentPlayerTest2()
		{
			var methods = new Methods();
			var result = methods.ChangePlayer();
			Assert.AreEqual('O', result);
		}

		[TestMethod()]
		public void PlaceXTest()
		{
			var methods = new Methods();
			char[] TestFields = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
			methods.MakeMove('X', 5, TestFields);
			Assert.AreEqual('X', TestFields[5]);
		}

		[TestMethod()]
		public void PlaceOTest()
		{
			var methods = new Methods();
			char[] TestFields = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
			methods.MakeMove('O', 6, TestFields);

			Assert.AreEqual('O', TestFields[6]); //check if result is 0
			
		}

		[TestMethod()]
		public void UnoccupiedTest()
		{
			var methods = new Methods();
			char[] TestFields = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

			if (TestFields[6] != 'X' || TestFields[6] != 'O')
			{
				methods.MakeMove('O', 6, TestFields);
			}
			else
			{
				Assert.Fail("Space already occupied");
			}


			Assert.AreEqual('O', TestFields[6]); //check if result is 0

		}
	}
}
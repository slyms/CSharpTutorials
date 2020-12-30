﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using Xunit;

namespace AllenS_CSharpFundamentals.Tests
{
    /*Delegate
    - definition = points to any Method that takes a string & returns a string 
    -> points to ReturnMEssage()
    - WriteLogDelegate - Type to define Variables & Fields
    - WriteLogDelegateCanPointToMethod() calls ReturnMessage()
    */
    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            /*
            WriteLogDelegate log;

            //Invoke ReturnMessage()
            log = new WriteLogDelegate(ReturnMessage);
            //Alt 
            log = ReturnMessage;
            
            var result = log("Hello!");
            Assert.Equal("Hello!", result);
            */

            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Sly";
            var upper = MakeUpperCase(name);

            Assert.Equal("Sly", name);
            Assert.Equal("SLY", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void SetIntByRef()
        {
            var x = GetInt();
            Assert.Equal(3, x);

            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
           z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "Ref Name");
            Assert.Equal("Ref Name", book1.Name);

            GetBookSetNameOut(out book1, "Out Name");
            Assert.Equal("Out Name", book1.Name);
        }

        private void GetBookSetNameRef(ref InMemoryBook book, string name)
        {
            //Variable initialization is not obligatory
            book = new InMemoryBook(name);
        }

        private void GetBookSetNameOut(out InMemoryBook book, string name)
        {
            //Variable initialization is obligatory
            book = new InMemoryBook(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}

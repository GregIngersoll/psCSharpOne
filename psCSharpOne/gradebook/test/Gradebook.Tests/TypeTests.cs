using System;
using Xunit;


namespace Gradebook.Tests
{
   public class TypeTests
   {
      [Fact]
      public void Test1 ()
      {
         var x = GetInt();
         SetInt(out x);

         Assert.Equal(4, x);

      }

      private void SetInt(out int x)
      {
         x = 4;
      }

      private int GetInt()
      {
         return 3;
      }

      [Fact]
      public void StringsBehaveLikeValueTypes()
      {
         string name = "String1";
         
         string upper = MakeUppercase(name);

         Assert.Equal ("String1", name);
         Assert.Equal ("STRING1", upper);
      }

      private string MakeUppercase(string parameter)
      {
         return parameter.ToUpper();
      }

      [Fact]
      public void CanSetByRefByValue()
      {
         // Arrange
         var book1 = GetBook ("book1");
         // Act
         GetBookSetName (out book1, "foo");

         

         // Assert
         Assert.Equal ("foo", book1.Name);
      }

      private void GetBookSetName (out Book book, string name)
      {
         book = new Book(name);
      }

      [Fact]
      public void CanSetNameByValue()
      {
         // Arrange
         var book1 = GetBook ("book1");
         // Act
         GetBookSetName (book1, "foo");

         // Assert
         Assert.Equal ("book1", book1.Name);
      }

      private void GetBookSetName (Book book, string name)
      {
         book = new Book(name);
      }

      [Fact]
      public void CanSetNameFromReference()
      {
         // Arrange
         var book1 = GetBook ("book1");
         // Act
         SetName (book1, "foo");

         // Assert
         Assert.Equal ("foo", book1.Name);
      }

      private void SetName (Book book, string name)
      {
         book.Name = name;
      }

      [Fact]
      public void ReferencesSameObject()
      {
         // Arrange
         var book1 = GetBook ("book1");
         var book2 = book1;

         // Act

         // Assert
         Assert.Same (book1, book2);
         Assert.True (Object.ReferenceEquals(book1, book2));
      }

      private Book GetBook (string name)
      {
         return new Book (name);
      }

      public override bool Equals(object obj)
      {
         return base.Equals(obj);
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }

      public override string ToString()
      {
         return base.ToString();
      }
   }
}

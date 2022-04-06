using System;

namespace Guids
{
  public class Program
  {
    static void Main(string[] args)
    {
      var id = Guid.NewGuid();
      id.ToString();

      id = new Guid("0438d5f7-5994-48e8-b93c-e21391239131");


      Console.WriteLine(id.ToString().Substring(0, 8));
    }
  }
}
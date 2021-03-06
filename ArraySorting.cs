/*
Example Usage: 
ArraySorting[] arr = {
  new ArraySorting("Tiffany"),
  new ArraySorting("Carson"),
  new ArraySorting("Kenneth")
};
Array.Sort(arr);
*/

using System;
usibg System.NotImplementedException;

public class ArraySorting : IComparable {
  public ArraySorting(){}
  public ArraySorting(string s){
    name = s;
  }
  string name;
  
  public int CompareTo(object obj){
    //https://msdn.microsoft.com/en-us/library/system.icomparable.compareto(v=vs.110).aspx
    
    ArraySorting arr = obj as ArraySorting;
    if (arr==null){
      throw NotImplementedException;
    }
    return this.Name.CompareTo(arr.Name);
  }
}

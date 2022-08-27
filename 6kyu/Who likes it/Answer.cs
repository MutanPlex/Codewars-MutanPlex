using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    String a = "";
    if(name.Length == 0){
      a= "no one likes this";
    }
    if(name.Length == 1){
      a = name[0] + " likes this";
    }
    if(name.Length == 2){
      a = name[0] + " and " +name[1] + " like this";
    }
    if(name.Length == 3){
      a = name[0] + ", " +name[1] + " and " + name[2] + " like this";
    }
    if(name.Length > 3){
      a = name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
    }
    return a;
  }
}
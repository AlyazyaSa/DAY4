using System;

namespace day_4
{ 
    class program
    {


      static void Main()
      {


        #region
        //1- One Dimentsional Array:
        string[] size = new string[3];
        size[0] = "Small";
        size[1] = "Medium";
        size[2] = "Large";

       Console.WriteLine ("your size is : " + size[3]);
        #endregion




        #region
        //2-Multi Dimentsional Array:
        int[,] Id = new int[2, 2]; //2rew //2coloum
        Id[0, 0] = 33;
        Id[0, 1] = 24;
        Id[1, 0] = 39;
        Id[1, 1] = 40;
        Console.WriteLine("Id is: " + Id[2, 4]);
        #endregion


        #region
        //3-jagged array
        int[][] farmer = new int[2][];
        farmer[0] = new int[3] { 1, 2, 3, };
        farmer[1] = new int[2] { 1, 2 };
        #endregion
      }
    }

} 


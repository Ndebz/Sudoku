﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sudoku
{
    public class Levels
    {

        private int[] levelNums, levelAns;
        private string levelName;

        public Levels(string theLevel)
        {
            
            switch(theLevel){

                default:
                    levelAns  = new int[] {3,8,6,5,1,2,7,9,4,2,9,7,4,3,6,8,5,1,1,5,4,7,8,9,2,6,3,4,1,9,3,6,8,5,2,7,6,2,8,1,7,5,3,4,9,7,3,5,9,2,4,1,8,6,5,4,1,8,9,7,6,3,2,8,6,3,2,4,1,9,7,5,9,7,2,6,5,3,4,1,8};
                    levelNums = new int[] {3,0,6,5,0,0,0,9,0,2,0,0,4,0,0,8,5,1,1,0,0,7,8,0,0,6,0,0,0,9,3,6,8,5,0,0,6,2,8,0,0,0,3,4,9,0,0,5,9,2,4,1,0,0,0,4,0,0,9,7,0,0,2,8,6,3,0,0,1,0,0,5,0,7,0,0,0,3,4,0,8};
                    levelName = "Easy";
                break;

                 }
        }//Levels constructor


        public int[] getLevelNums()
        {
            return levelNums;
        }

        public int[] getLevelAns()
        {
            return levelAns;
        }

        public string getLevelName()
        {
            return levelName;
        }

        

    }
}
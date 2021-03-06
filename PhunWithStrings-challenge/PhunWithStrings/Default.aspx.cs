﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Reverse the letters
         
            string name = "Alex Martin";


                for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }
        

            //Reverse the sequence of names
            
            string names = "Luke,Leia,Han,Chewbaca";
          
            string[] rebelScum = names.Split(',');
            string result = "";
            for (int i = rebelScum.Length - 1; i >= 0; i--)
            {
                result += rebelScum[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text = result;
         

            /*
            Do this
            *****luke*****
            *****leia*****
            ******han******
            **chewbacca**
            */
            /*
            string[] rebelScum = names.Split(',');
            string result = "";
            for (int i = 0; i < rebelScum.Length; i++)
            {
                int padLeft = (14 - rebelScum[i].Length) / 2;
                string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br/>";
               }
            resultLabel.Text = result;
         */

            //Solve the puzzle
            
            string puzzle = "NOW IS ZHEremove-me ZINE FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY";
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");

          resultLabel.Text = puzzle;


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name

            // iterated to reposition letters this is like what we did in 
            //small basic. Review from notes.

            /*
            string name = "Dianna Kelley";
            string result = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                result += name[i];
            }
            resultLabel.Text = result;

            */

            //2.Reverse this sequence:
            // create a name array [4]
            // iterate through to put in alphabetical order.
            //use first letter of array name for sort.

            /*
           string name = "Luke,Leia,Han,Chewbacca";
            string[] namez = name.Split(',');
            string result = "";
            for (int i = namez.Length - 1; i >= 0; i--)
            {
                result += namez[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            resultLabel.Text += result;
           */



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            //// *****han******
            //// **Chewbacca***

            // length.max=14
            //center text, change '' to '*'
            //or on array, default '' is created.possibly change '' to * for array value.

            /*
            string names = "Luke,Leia,Han,Chewbacca";
            string[] namez = names.Split(',');
            string result = "";
            for (int i = 0; i < namez.Length; i++)
            {
                int padLeft = (14 - namez[i].Length) / 2;
                string temp = namez[i].PadLeft(namez[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br/>";
            }
            resultLabel.Text = result;
            */


            //// 4. Solve this puzzle:
            //// Once you fix it with string helper methods, it should read:
            //// Now is the time for all good men to come to the aid of their country.


            //iterate through, replace Z with t
            //iterate through , replace remove-me with ''
            //replace capital letters with toLower.text

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            puzzle = puzzle.Replace("remove-me", " ");
            puzzle = puzzle.Replace('Z', 'T');
            puzzle = puzzle.ToLower();
            puzzle = char.ToUpper(puzzle[0]) + puzzle.Substring(1);

            resultLabel.Text = puzzle;
        }

              
        
    }
}
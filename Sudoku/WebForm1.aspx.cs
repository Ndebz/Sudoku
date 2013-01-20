using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;




namespace Sudoku
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        private string currentGame = "easy";

        public void setCurrentGame(string theCurrentGame){

            currentGame = theCurrentGame;
            
        }

        public string returnCurrentGame()
        {
            return currentGame;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {


            Levels loadGame = new Levels(currentGame);

            int [] gameNums =  loadGame.getLevelNums();
            int inc = 1;
            foreach(int i in gameNums){

                if (i != 0)
                {
                    TextBox tb = (TextBox)FindControl("TextBox" + inc);
                    tb.Text = i.ToString();
                    //tb.ReadOnly = true;
                    tb.Enabled = false;
                }
                else {
                    //leave blank and move to next box
                }

                inc++;
            }
            //TextBox tb1 = (TextBox)FindControl("TextBox"+1);
            //tb1.Text = "hello world";

            
           
        }

        protected void CheckAns_Click(object sender, EventArgs e)
        {
            
            Levels loadGameAns = new Levels(returnCurrentGame());

            int[] theAns = loadGameAns.getLevelAns();
            int inc = 1;
            foreach(int i in theAns){

                TextBox tb = (TextBox)FindControl("TextBox" + inc);

                if (tb.Text != i.ToString())
                {
                    tb.BackColor = Color.Red;
                }
                else
                {
                    //do nothing
                }

                inc++;
            }
        }
    }
}
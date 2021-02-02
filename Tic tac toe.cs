using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string players = "Player 1: X  | Player 2: O";
            Console.WriteLine(players);
            string row1 = "     0   1   2  ";
            string row2 = " 0 |   |   |   |";
            string row3 = " 1 |   |   |   |";
            string row4 = " 2 |   |   |   |";
            Console.WriteLine(row1);
            Console.WriteLine(row2);
            Console.WriteLine(row3);
            Console.WriteLine(row4);
            bool winner = true;
            int counter = 0;
            while (winner == true)
            {
                //row2 win
                if ((row2[5] == row2[9] && row2[5] == row2[13] && row2[5] == players[10]) ||
                        (row2[5] == row2[9] && row2[5] == row2[13] && row2[5] == players[25]))
                {
                    winner = false;
                    
                }
                //row3 win
                else if ((row3[5] == row3[9] && row3[5] == row3[13] && row3[5] == players[10]) ||
                    (row3[5] == row3[9] && row3[5] == row3[13] && row3[5] == players[25]))
                {
                    winner = false;
                   
                }
                //row4 win
                else if ((row4[5] == row4[9] && row4[5] == row4[13] && row4[5] == players[10]) ||
                        (row4[5] == row4[9] && row4[5] == row4[13] && row4[5] == players[25]))
                {
                    winner = false;
                    
                }
               
                //cow1 win
                else if ((row2[5] == row3[5] && row2[5] == row4[5] && row2[5] == players[10]) ||
                        (row2[5] == row3[5] && row2[5] == row4[5] && row2[5] == players[25]))
                {
                    winner = false;
                   
                }
                //cow2 win
                else if ((row2[9] == row3[9] && row2[9] == row4[9] && row2[9] == players[10]) ||
                        (row2[9] == row3[9] && row2[9] == row4[9] && row2[9] == players[25]))
                {
                    winner = false;
                    
                }
                //cow3 win
                else if ((row2[13] == row3[13] && row2[13] == row4[13] && row2[13] == players[10]) ||
                        (row2[13] == row3[13] && row2[13] == row4[13] && row2[13] == players[25]))
                {
                    winner = false;
                    
                }
                //first X win
                else if ((row2[5] == row3[9] && row2[5] == row4[13] && row2[5] == players[10]) ||
                        (row2[5] == row3[9] && row2[5] == row4[13] && row2[5] == players[25]))
                {
                    winner = false;
                    
                }
                // second X win
                else if ((row2[13] == row3[9] && row2[13] == row4[5] && row2[13] == players[10]) ||
                        (row2[13] == row3[9] && row2[13] == row4[5] && row2[13] == players[25]))
                {
                    winner = false;
                    
                }
                else
                {
                    Console.Write("Enter row from 0 to 2: ");
                    string enteredRow = Console.ReadLine();
                    Console.Write("Enter col from 0 to 2: ");
                    string enteredCol = Console.ReadLine();
                    
                    if (enteredRow == "0" && enteredCol == "0")
                    {
                        if (counter % 2 == 0)
                        {
                            row2 = row2.Insert(5, "X");
                            row2 = row2.Remove(6, 1);
                        }
                        else
                        {
                            row2 = row2.Insert(5, "O");
                            row2 = row2.Remove(6, 1);
                        }
                    }
                    else if (enteredRow == "1" && enteredCol == "0")
                    {
                        if (counter % 2 == 0)
                        {
                            row3 = row3.Insert(5, "X");
                            row3 = row3.Remove(6, 1);
                        }
                        else
                        {
                            row3 = row3.Insert(5, "O");
                            row3 = row3.Remove(6, 1);
                        }
                    }
                    else if (enteredRow == "2" && enteredCol == "0")
                    {
                        if (counter % 2 == 0)
                        {
                            row4 = row4.Insert(5, "X");
                            row4 = row4.Remove(6, 1);
                        }
                        else
                        {
                            row4 = row4.Insert(5, "O");
                            row4 = row4.Remove(6, 1);
                        }
                    }
                    else if (enteredRow == "0" && enteredCol == "1")
                    {
                        if (counter % 2 == 0)
                        {
                            row2 = row2.Insert(9, "X");
                            row2 = row2.Remove(10, 1);
                        }
                        else
                        {
                            row2 = row2.Insert(9, "O");
                            row2 = row2.Remove(10, 1);
                        }
                    }
                    else if (enteredRow == "0" && enteredCol == "2")
                    {
                        if (counter % 2 == 0)
                        {
                            row2 = row2.Insert(13, "X");
                            row2 = row2.Remove(14, 1);
                        }
                        else
                        {
                            row2 = row2.Insert(13, "O");
                            row2 = row2.Remove(14, 1);
                        }
                    }
                    else if (enteredRow == "1" && enteredCol == "1")
                    {
                        if (counter % 2 == 0)
                        {
                            row3 = row3.Insert(9, "X");
                            row3 = row3.Remove(10, 1);
                        }
                        else
                        {
                            row3 = row3.Insert(9, "O");
                            row3 = row3.Remove(10, 1);
                        }
                    }
                    else if (enteredRow == "1" && enteredCol == "2")
                    {
                        if (counter % 2 == 0)
                        {
                            row3 = row3.Insert(13, "X");
                            row3 = row3.Remove(14, 1);
                        }
                        else
                        {
                            row3 = row3.Insert(13, "O");
                            row3 = row3.Remove(14, 1);
                        }
                    }
                    else if (enteredRow == "2" && enteredCol == "1")
                    {
                        if (counter % 2 == 0)
                        {
                            row4 = row4.Insert(9, "X");
                            row4 = row4.Remove(10, 1);
                        }
                        else
                        {
                            row4 = row4.Insert(9, "O");
                            row4 = row4.Remove(10, 1);
                        }
                    }
                    else if (enteredRow == "2" && enteredCol == "2")
                    {
                        if (counter % 2 == 0)
                        {
                            row4 = row4.Insert(13, "X");
                            row4 = row4.Remove(14, 1);
                        }
                        else
                        {
                            row4 = row4.Insert(13, "O");
                            row4 = row4.Remove(14, 1);
                        }
                    }
                    counter++;
                    Console.WriteLine(row1);
                    Console.WriteLine(row2);
                    Console.WriteLine(row3);
                    Console.WriteLine(row4);
                    if (counter > 8)
                    {
                        Console.WriteLine("Draw!");
                        return;
                    }
                }  
            }
            if(counter % 2 == 1)
            {
                Console.WriteLine("Player1 - X wins");
            }
            else
            {
                Console.WriteLine("Player2 - O wins");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    public partial class Map : Form
    {

        int dim = 0;
        int MineCounter = 0;
        Cell[][] MapMine;
        public Map()
        {
            InitializeComponent();
        }

        void GenerateMinesRandom()
        {
            for(int m=1;m<=MineCounter;m++)
            {
                Random rnd = new Random();

                int x, y;
                do
                {
                x = rnd.Next(dim);
                y = rnd.Next(dim);
                }while(MapMine[x][y].val==-1);
                MapMine[x][y].val = -1;


                 for (int ri = x - 1; ri <= x + 1; ri++)
                  {
                      if (ri < 0 || ri >= dim)
                          continue;
                      for (int ci = y - 1; ci <= y + 1; ci++)
                      {
                          if (ci < 0 || ci >= dim)
                              continue;
                          if (MapMine[ri][ci].val != -1)
                          {
                              MapMine[ri][ci].val++;
                          }
                      }

                  }

                
            }
        }


        void winCondition()
        {
            int count = 0;
            for(int ri=0;ri<dim;ri++)
            {
                for(int ci=0;ci<dim;ci++)
                {
                    if(MapMine[ri][ci].isOpen==false)
                    {
                        count++;
                    }
                }
            }
            if(count==dim+2)
            {
                string message2 = "Do you want to continue The Game?";
                string caption2 = "MineSweeper";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result2;
                MessageBox.Show("You win :)");
                result2 = MessageBox.Show(message2, caption2,buttons);
                if(result2==System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Select the difficulty.");
                    CellMap.Controls.Clear();
                
                }
                else
                {
                    this.Close();
                }
            }
        }


        bool zerosSurroundingOpen(int ri,int ci)
        {
            for (int r = ri - 1; r < ri + 2; r++)
            {
                for (int c = ci - 1; c < ci + 2; c++)
                {
                    if(!(r<0 || r>=dim || c<0 || c>=dim))
                    {
                        if(MapMine[r][c].isOpen==false)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        void openConnectedZeros()
        {
            bool happen = false;
            do
            {
                for (int ri = 0; ri < dim; ri++)
                {
                    for (int ci = 0; ci < dim; ci++)
                    {
                        if(MapMine[ri][ci].val==0 && MapMine[ri][ci].isOpen==true && zerosSurroundingOpen( ri, ci)==false)
                        {
                            for(int r=ri-1;r<ri+2;r++)
                            {
                                for(int c=ci-1;c<ci+2;c++)
                                {
                                    if(!(r<0 || r>=dim || c<0 || c>=dim))
                                    {
                                        if(MapMine[r][c].isOpen==false)
                                        {
                                            happen = true;
                                            if(MapMine[r][c].val!=0)
                                            {
                                                MapMine[r][c].Text = MapMine[r][c].val.ToString();
                                            }
                                            MapMine[r][c].isOpen = true;
                                            MapMine[r][c].BackColor = Color.DarkGray;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }while(happen==true);
        }

        private bool ISZsOpen(int CRI, int CCI)
        {
            for (int R = CRI - 1; R < CRI + 2; R++)
            {
                for (int C = CCI - 1; C < CCI + 2; C++)
                {
                    if (!(R < 0 || R >= dim || C < 0 || C >= dim))
                    {
                        if (MapMine[R][C].isOpen == false)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void OpenZeroSwamp()
        {
            bool happen = false;
            do
            {
                happen = false;
                for (int Ri = 0; Ri < dim; Ri++)
                {
                    for (int Ci = 0; Ci < dim; Ci++)
                    {
                        if (MapMine[Ri][Ci].val == 0 && MapMine[Ri][Ci].isOpen == true && ISZsOpen(Ri, Ci) == false)
                        {
                            for (int r = Ri - 1; r < Ri + 2; r++)
                            {
                                for (int c = Ci - 1; c < Ci + 2; c++)
                                {
                                    if (!(r < 0 || r >= dim || c < 0 || c >= dim))
                                    {
                                        if (MapMine[r][c].isOpen == false)
                                        {
                                            happen = true;
                                            if (MapMine[r][c].val != 0)
                                            {
                                                MapMine[r][c].Text = MapMine[r][c].val.ToString();
                                            }
                                            MapMine[r][c].isOpen = true;
                                            MapMine[r][c].BackColor = Color.DarkGray;

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (happen == true);
        }

        private void ClickedHappen(object sender, EventArgs e)
        {
            Cell A = (Cell)sender;
            A.BackColor = Color.Red;
           // A.isOpen = true;

            A.Text = A.val.ToString();
            if(A.val==-1)
            {
                for(int ri=0;ri<dim;ri++)
                {
                    for(int ci=0;ci<dim;ci++)
                    {
                        if(MapMine[ri][ci].isOpen==false)
                        {
                            MapMine[ri][ci].BackColor = Color.Red;
                            MapMine[ri][ci].Text = MapMine[ri][ci].val.ToString();
                            MapMine[ri][ci].isOpen = true;
                        }
                    }
                }
                string message = "Do you want to continue The Game?";
                string caption = "MineSweeper";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                MessageBox.Show("You have been lost The Game...!!!");
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Select the difficulty.");
                    CellMap.Controls.Clear();
                }
                else
                {
                    this.Close();
                }
            }

            else if (A.val > 0 && A.isOpen == false)
            {
                A.isOpen = true;
                A.BackColor = Color.DarkGray;
                A.Text = A.val.ToString();
            }
            else if (A.val == 0 && A.isOpen == false)
            {
                A.isOpen = true;
                A.BackColor = Color.DarkGray;
                OpenZeroSwamp();
            }
            
            winCondition();
            
        }
     
      
        private void Start_Click(object sender, EventArgs e)
        {
            CellMap.Controls.Clear();
            if(Easy.Checked)
            {
               dim = 5;
               MineCounter = dim + 2;
            }
            else if(Medium.Checked)
            {
                dim = 8;
                MineCounter = dim + 2;
            }
            else if(Expert.Checked)
            {
                dim = 10;
                MineCounter = dim + 2;
            }
            else
            {
                MessageBox.Show("You must select difficulty!!!");
                return;
            }

            MapMine = new Cell[dim][];
            for (int ri = 0; ri < dim;ri++ )
            {
                MapMine[ri] = new Cell[dim];
            }

                for (int ri = 0; ri < dim; ri++)
                {
                    for (int ci = 0; ci < dim; ci++)
                    {
                        MapMine[ri][ci] = new Cell(ri, ci, CellMap.Width, CellMap.Height,dim);
                        MapMine[ri][ci].Click+=new System.EventHandler(this.ClickedHappen);
                        CellMap.Controls.Add(MapMine[ri][ci]);
                        MapMine[ri][ci].BackColor = Color.Turquoise;
                        

                    }
                }

                GenerateMinesRandom();
               

        }


    }
}

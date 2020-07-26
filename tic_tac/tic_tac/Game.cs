using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace tic_tac {
    public class Game {

        private int[,] grid;
        private bool turn = true;

        public Game() {
            this.grid = new int[,] {
                {0,0,0},
                {0,0,0},
                {0,0,0}
            };
        }

        public int take_turn(int x, int y) {
            if (grid[x, y] != 0) {
                return -1;
            } else {
                grid[x, y] = turn ? 1 : 2;
                turn = !turn;
                return grid[x, y];
            }
        }
        
        public int[,] get_board() {
            return grid.Clone() as int[,];
        }

        public int get_winner() {
            for (int i = 0; i < grid.GetLength(0); i++) {
                if (grid[i, 0] == grid[i, 1] && grid[i, 0] == grid[i, 2] && grid[i, 0] != 0) {
                    // ROW
                    return this.grid[i, 0];
                } else if (grid[0, i] == grid[1, i] && grid[0, i] == grid[2, i] && grid[0, i] != 0) {
                    // COL
                    return this.grid[0, i];
                } else if (grid[1, 1] * 2 == grid[0, 2] + grid[2, 0] && grid[1, 1] != 0) {
                    // DIAG
                    return grid[1, 1];
                } else if (grid[1, 1] * 2 == grid[0, 0] + grid[2, 2] && grid[1, 1] != 0) {
                    // DIAG
                    return grid[1, 1];
                }
            }
            return -1;
        }

        public void show_board() {
            Debug.WriteLine("#####");
            for(int i = 0; i < grid.GetLength(0); i++) {
                for(int j = 0; j < grid.GetLength(0); j++) {
                    Debug.Write(grid[i,j] + " ");
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("#####");
        }
    }
}

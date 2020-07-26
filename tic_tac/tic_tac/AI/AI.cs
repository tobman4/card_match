using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using tic_tac;

namespace tic_tac.AI {
    public class AI {
        /// <summary>
        /// the AI asume it wil get a 3x3 board
        /// </summary>
        public int team = 1;
        public AI() {
        }
        public int[] get_move(int[,] state) {
            int[] move = new int[2];
            int[,] s = get_score(state);
            int best = 0;
            for(int i = 0; i < s.GetLength(0); i++) {
                for(int j = 0; j < s.GetLength(0); j++) {
                    if(s[j,i] > best) {
                        move = new int[] {i,j};
                        best = s[j, i];
                        //Debug.WriteLine("new best = " + s[j,i] + "(" + i +"," + j + ")");
                    }
                    Debug.Write(s[j,i] + "\t");
                }
                Debug.WriteLine("");
            }
            return move;
        }

        public int[,] get_score(int[,] state) { // TODO: swap to private
            int[,] o = state.Clone() as int[,];
            int[,] score_board = new int[,] {
                { 2, 1, 2},
                { 1, 5, 2},
                { 2, 1, 2},
            };
            for (int i = 0; i < o.GetLength(0); i++) {
                for (int j = 0; j < o.GetLength(0); j++) {
                    if(o[j,i] != 0) {
                        score_board[j, i] = -1;
                    }
                }
                Debug.WriteLine("");
            }
            return score_board;
        }
    }
}

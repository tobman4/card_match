using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

using tic_tac.AI;

namespace tic_tac {
    public partial class Form1 : Form {

        private Game game;
        private tic_tac.AI.AI ai;
        private Label[,] board;

        public Form1() {
            InitializeComponent();

            board = new Label[,] {
                { p00,p10,p20 },
                { p01,p11,p21 },
                { p02,p12,p22 }
            };
        }

        private void Form1_Load(object sender, EventArgs e) {
            game = new Game();
            ai = new AI.AI();

            update_board();
            ai.get_score(game.get_board());

        }

        private void update_board() {
            int[,] state = game.get_board();
            for(int i = 0; i < state.GetLength(0); i++) {
                for (int j = 0; j < state.GetLength(0); j++) {
                    if(state[i, j] == 0) {
                        board[j, i].Text = "HOLD";
                    } else {
                        board[j, i].Text = state[i, j] == 1 ? "X" : "O";
                    }
                }
            }
        }

        private void pXX_Click(object sender, EventArgs e) {
            Label pressed = (sender as Label);
            String name = pressed.Name.Replace("p","");
            int x = Int32.Parse(name[0].ToString());
            int y = Int32.Parse(name[1].ToString());
            game.take_turn(x,y);
            update_board();
        }

        private void button1_Click(object sender, EventArgs e) {
            ai.get_move(game.get_board());
        }

        private void ai_take_turn_Click(object sender, EventArgs e) {
            int[] pos = ai.get_move(game.get_board());
            game.take_turn(pos[0],pos[1]);
            update_board();
        }
    }
}

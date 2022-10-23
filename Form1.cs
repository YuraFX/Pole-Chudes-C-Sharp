//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pole_Chudes_Beta_1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "PCH.wav";
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {      
            MenuBack.Visible = false;
            btnNewGame.Visible = false;
            btnNewGame.Enabled = false;
            GameBack.Visible = true;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            lblEnterName.Visible = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            player.PlayLooping();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            if (tbPName.Text == "")
            {
                lblErr.Visible = true;
            }
            else
            {
                lblErr.Visible = false;
                btnProg.Visible = false;
                btnPoc.Visible = false;
                btnRast.Visible = false;
                btnProg.Enabled = false;
                btnPoc.Enabled = false;
                btnRast.Enabled = false;
                lblVybor.Visible = false;
                ThemeBack.Visible = false;
                lblEnterName.Visible = false;
                tbPName.Visible = false;
                tbPName.Enabled = false;
                pbPlayerStatus.Visible = true;
                lblPlayerName1.Text = tbPName.Text;
                lblPlayerName1.Visible = true;
                pbGProg1.Visible = true;
                pbGProg2.Visible = true;
                pbGProg3.Visible = true;
                pbGProg4.Visible = true;
                pbGProg5.Visible = true;
                pbGProg6.Visible = true;
                List.Visible = true;
                timer1.Enabled = true;
                выбратьДругуюТемуToolStripMenuItem.Visible = true;
            }
        }

        private void btnPoc_Click(object sender, EventArgs e)
        {
            if (tbPName.Text == "")
            {
                lblErr.Visible = true;
            }
            else
            {
                lblErr.Visible = false;
                btnProg.Visible = false;
                btnPoc.Visible = false;
                btnRast.Visible = false;
                btnProg.Enabled = false;
                btnPoc.Enabled = false;
                btnRast.Enabled = false;
                lblVybor.Visible = false;
                ThemeBack.Visible = false;
                lblEnterName.Visible = false;
                tbPName.Visible = false;
                tbPName.Enabled = false;
                pbPlayerStatus.Visible = true;
                lblPlayerName1.Text = tbPName.Text;
                lblPlayerName1.Visible = true;
                pbGProg1.Visible = true;
                pbGProg2.Visible = true;
                pbGProg3.Visible = true;
                pbGProg4.Visible = true;
                pbGProg5.Visible = true;
                pbGProg6.Visible = true;
                pbGProg7.Visible = true;
                List.Visible = true;
                timer9.Enabled = true;
                выбратьДругуюТемуToolStripMenuItem1.Visible = true;
            }
        }

        private void btnRast_Click(object sender, EventArgs e)
        {
            if (tbPName.Text == "")
            {
                lblErr.Visible = true;
            }
            else
            {
                lblErr.Visible = false;
                btnProg.Visible = false;
                btnPoc.Visible = false;
                btnRast.Visible = false;
                btnProg.Enabled = false;
                btnPoc.Enabled = false;
                btnRast.Enabled = false;
                lblVybor.Visible = false;
                ThemeBack.Visible = false;
                lblEnterName.Visible = false;
                tbPName.Visible = false;
                tbPName.Enabled = false;
                pbPlayerStatus.Visible = true;
                lblPlayerName1.Text = tbPName.Text;
                lblPlayerName1.Visible = true;
                List.Visible = true;
                pbGProg1.Visible = true;
                pbGProg2.Visible = true;
                pbGProg3.Visible = true;
                pbGProg4.Visible = true;
                pbGProg5.Visible = true;
                pbGProg6.Visible = true;
                timer17.Enabled = true;
                выбратьДругуюТемуToolStripMenuItem2.Visible = true;
            }
        }

        private void btnCosmo_Click(object sender, EventArgs e)
        {
            if (tbPName.Text == "")
            {
                lblErr.Visible = true;
            }
            else
            {
                lblErr.Visible = false;
                btnProg.Visible = false;
                btnPoc.Visible = false;
                btnRast.Visible = false;
                btnProg.Enabled = false;
                btnPoc.Enabled = false;
                btnRast.Enabled = false;
                lblVybor.Visible = false;
                ThemeBack.Visible = false;
                lblEnterName.Visible = false;
                tbPName.Visible = false;
                tbPName.Enabled = false;
                pbPlayerStatus.Visible = true;
                lblPlayerName1.Text = tbPName.Text;
                lblPlayerName1.Visible = true;
                List.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTextProg1.Visible = true;
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTextProg1.Visible = false;
            lblCount.Visible = true;
            btnBaraban.Enabled = true;
            btnBaraban.Visible = true;
            lblBarabanResult.Visible = true;
            lblNaBarabane.Visible = true;
            timer2.Enabled = false;
            btnSrazyProg.Visible = true;
            btnSrazyProg.Enabled = true;
        }

        private void btnBaraban_Click(object sender, EventArgs e)
        {
            lblNaBarabane.Text = (new Random().Next(51)).ToString();
            btnBaraban.Visible = false;
            btnBaraban.Enabled = false;
            btnSrazyProg.Visible = false;
            btnSrazyProg.Enabled = false;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = true;
            lblOchki.Visible = true;
            lblBukva.Visible = true;
            lblVyvodBar.Visible = true;
            lblVyvodBar.Text = lblNaBarabane.Text;
            timer3.Enabled = false;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = false;
            lblOchki.Visible = false;
            lblBukva.Visible = false;
            lblVyvodBar.Visible = false;
            timer4.Enabled = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
            button25.Visible = true;
            button26.Visible = true;
            button27.Visible = true;
            button28.Visible = true;
            button29.Visible = true;
            button30.Visible = true;
            button31.Visible = true;
            button32.Visible = true;
            button33.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            lblB.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblB.Visible == true)
            {
                lblOne.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblOne.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            lblA.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblA.Visible == true)
            {
                lblTwo.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblTwo.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            lblI.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblI.Visible == true)
            {
                lblThree.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblThree.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            lblS.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblS.Visible == true)
            {
                lblFour.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblFour.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            lblii.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblii.Visible == true)
            {
                lblFive.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblFive.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            lblC.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            timer5.Enabled = true;
            lblTextProg2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            if (lblC.Visible == true)
            {
                lblSix.Enabled = true;
                lblSlovoCount.Text = (int.Parse(lblSix.Text) + int.Parse(lblSlovoCount.Text)).ToString();
            }
            if (lblSlovoCount.Text == "6")
            {
                timer8.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer5.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            lblTextProg2.Visible = false;
            btnBaraban.Visible = true;
            btnBaraban.Enabled = true;
            lblNaBarabane.Visible = true;
            btnSrazyProg.Visible = true;
            btnSrazyProg.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else 
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button1.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button3.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button4.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button5.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button19.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button22.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button25.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button10.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button11.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button12.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button20.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button23.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button26.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button14.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button15.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button16.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button17.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button18.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button21.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button24.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button27.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button28.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button29.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button30.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button31.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button32.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer6.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
            }
            else
            {
                timer7.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban.Visible = false;
                btnBaraban.Enabled = false;
                lblCount.Text = "0";
            }
            button33.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            button25.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Close();
            timer6.Enabled = false;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            lblTextProg4.Visible = false;
            btnBaraban.Visible = true;
            btnBaraban.Enabled = true;
            lblNaBarabane.Visible = true;
            timer7.Enabled = false;
            btnSrazyProg.Visible = true;
            btnSrazyProg.Enabled = true;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            lblB.Visible = false;
            lblA.Visible = false;
            lblI.Visible = false;
            lblS.Visible = false;
            lblii.Visible = false;
            lblC.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban.Visible = false;
            btnBaraban.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            lblSlovoCount.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            tbSrazyProg.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            btnSrazyProg.Visible = false;
            btnSrazyProg.Enabled =false;
            выбратьДругуюТемуToolStripMenuItem.Visible = false;
        }

        private void btnSrazyProg_Click(object sender, EventArgs e)
        {
            btnSrazyProg.Visible = false;
            btnSrazyProg.Enabled = false;
            btnBaraban.Visible = false;
            btnBaraban.Enabled = false;
            btnProgClose.Visible = true;
            btnProgClose.Enabled = true;
            tbSrazyProg.Visible = true;
            tbSrazyProg.Enabled = true;
            btnProgOk.Visible = true;
            btnProgOk.Enabled = true;
        }

        private void btnProgClose_Click(object sender, EventArgs e)
        {
            btnSrazyProg.Visible = true;
            btnSrazyProg.Enabled = true;
            btnBaraban.Visible = true;
            btnBaraban.Enabled = true;
            btnProgClose.Visible = false;
            btnProgClose.Enabled = false;
            tbSrazyProg.Visible = false;
            tbSrazyProg.Enabled = false;
            btnProgOk.Visible = false;
            btnProgOk.Enabled = false;
        }

        private void btnProgOk_Click(object sender, EventArgs e)
        {
            if (tbSrazyProg.Text == "БЕЙСИК")
            {
                lblTextProg2.Visible = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer8.Enabled = true;
                btnProgClose.Visible = false;
                btnProgClose.Enabled = false;
                tbSrazyProg.Visible = false;
                tbSrazyProg.Enabled = false;
                btnProgOk.Visible = false;
                btnProgOk.Enabled = false;
                lblB.Visible = true;
                lblA.Visible = true;
                lblI.Visible = true;
                lblS.Visible = true;
                lblii.Visible = true;
                lblC.Visible = true;
            }
            else
            {
                lblTextProg3.Visible = true;
                btnProgClose.Visible = false;
                btnProgClose.Enabled = false;
                tbSrazyProg.Visible = false;
                tbSrazyProg.Enabled = false;
                btnProgOk.Visible = false;
                btnProgOk.Enabled = false;
                timer6.Enabled = true;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timer9.Enabled = false;
            lblTextPoc1.Visible = true;
            timer10.Enabled = true;
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            timer10.Enabled = false;
            lblTextPoc1.Visible = false;
            lblCount.Visible = true;
            lblBarabanResult.Visible = true;
            lblNaBarabane.Visible = true;
            btnBaraban2.Enabled = true;
            btnBaraban2.Visible = true;
            btnSrazyPoc.Visible = true;
            btnSrazyPoc.Enabled = true;
        }

        private void btnBaraban2_Click(object sender, EventArgs e)
        {
            lblNaBarabane.Text = (new Random().Next(51)).ToString();
            btnBaraban2.Visible = false;
            btnBaraban2.Enabled = false;
            timer11.Enabled = true;
            btnSrazyPoc.Visible = false;
            btnSrazyPoc.Enabled = false;
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = true;
            lblOchki.Visible = true;
            lblBukva.Visible = true;
            lblVyvodBar.Visible = true;
            lblVyvodBar.Text = lblNaBarabane.Text;
            timer11.Enabled = false;
            timer12.Enabled = true;
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = false;
            lblOchki.Visible = false;
            lblBukva.Visible = false;
            lblVyvodBar.Visible = false;
            timer12.Enabled = false;
            button34.Visible = true;
            button35.Visible = true;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
            button49.Visible = true;
            button50.Visible = true;
            button51.Visible = true;
            button52.Visible = true;
            button53.Visible = true;
            button54.Visible = true;
            button55.Visible = true;
            button56.Visible = true;
            button57.Visible = true;
            button58.Visible = true;
            button59.Visible = true;
            button60.Visible = true;
            button61.Visible = true;
            button62.Visible = true;
            button63.Visible = true;
            button64.Visible = true;
            button65.Visible = true;
            button66.Visible = true;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            button58.Enabled = false;
            lblK.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblK.Visible == true)
            {
                label2.Enabled = true;
                label1.Text = (int.Parse(label2.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.Enabled = false;
            lblO.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblO.Visible == true)
            {
                label3.Enabled = true;
                label1.Text = (int.Parse(label3.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.Enabled = false;
            lblN.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblN.Visible == true)
            {
                label4.Enabled = true;
                label1.Text = (int.Parse(label4.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.Enabled = false;
            lblY.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblY.Visible == true)
            {
                label5.Enabled = true;
                label1.Text = (int.Parse(label5.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.Enabled = false;
            lblSH.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblSH.Visible == true)
            {
                label6.Enabled = true;
                label1.Text = (int.Parse(label6.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            button61.Enabled = false;
            lblE.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblE.Visible == true)
            {
                label7.Enabled = true;
                label1.Text = (int.Parse(label7.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            button64.Enabled = false;
            lblV.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer13.Enabled = true;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
            if (lblV.Visible == true)
            {
                label8.Enabled = true;
                label1.Text = (int.Parse(label8.Text) + int.Parse(label1.Text)).ToString();
            }
            if (label1.Text == "7")
            {
                timer16.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer13.Enabled = false;
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            timer13.Enabled = false;
            lblTextProg2.Visible = false;
            btnBaraban2.Visible = true;
            btnBaraban2.Enabled = true;
            lblNaBarabane.Visible = true;
            btnSrazyPoc.Enabled = true;
            btnSrazyPoc.Visible = true;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button66.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button65.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button63.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button62.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button48.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button45.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button42.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button60.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button59.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button57.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button56.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button44.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button41.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button54.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button53.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button52.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button51.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button50.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button49.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button46.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button40.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button39.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button37.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button36.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button35.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer14.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            else
            {
                timer15.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban2.Visible = false;
                btnBaraban2.Enabled = false;
                lblCount.Text = "0";
            }
            button34.Enabled = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            button51.Visible = false;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            button58.Visible = false;
            button59.Visible = false;
            button60.Visible = false;
            button61.Visible = false;
            button62.Visible = false;
            button63.Visible = false;
            button64.Visible = false;
            button65.Visible = false;
            button66.Visible = false;
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            Close();
            timer14.Enabled = false;
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            lblTextProg4.Visible = false;
            btnBaraban2.Visible = true;
            btnBaraban2.Enabled = true;
            lblNaBarabane.Visible = true;
            timer15.Enabled = false;
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            timer9.Enabled = false;
            timer10.Enabled = false;
            timer11.Enabled = false;
            timer12.Enabled = false;
            timer13.Enabled = false;
            timer14.Enabled = false;
            timer15.Enabled = false;
            timer16.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            pbGProg7.Visible = false;
            lblK.Visible = false;
            lblO.Visible = false;
            lblN.Visible = false;
            lblY.Visible = false;
            lblSH.Visible = false;
            lblE.Visible = false;
            lblV.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban2.Visible = false;
            btnBaraban2.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            label1.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            tbSrazyPoc.Text = "";
            btnSrazyPoc.Visible = false;
            btnSrazyPoc.Enabled = false;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button45.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button53.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;
            button61.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            выбратьДругуюТемуToolStripMenuItem1.Visible = false;
        }

        private void btnSrazyPoc_Click(object sender, EventArgs e)
        {
            btnSrazyPoc.Visible = false;
            btnSrazyPoc.Enabled = false;
            btnBaraban2.Visible = false;
            btnBaraban2.Enabled = false;
            tbSrazyPoc.Visible = true;
            tbSrazyPoc.Enabled = true;
            btnPocClose.Visible = true;
            btnPocClose.Enabled = true;
            btnPocOk.Visible = true;
            btnPocOk.Enabled = true;
        }

        private void btnPocClose_Click(object sender, EventArgs e)
        {
            btnSrazyPoc.Visible = true;
            btnSrazyPoc.Enabled = true;
            btnBaraban2.Visible = true;
            btnBaraban2.Enabled = true;
            tbSrazyPoc.Visible = false;
            tbSrazyPoc.Enabled = false;
            btnPocClose.Visible = false;
            btnPocClose.Enabled = false;
            btnPocOk.Visible = false;
            btnPocOk.Enabled = false;
        }

        private void btnPocOk_Click(object sender, EventArgs e)
        {
            if (tbSrazyPoc.Text == "КОНЫШЕВ")
            {
                lblTextProg2.Visible = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                btnPocClose.Visible = false;
                btnPocClose.Enabled = false;
                tbSrazyPoc.Visible = false;
                tbSrazyPoc.Enabled = false;
                btnPocOk.Visible = false;
                btnPocOk.Enabled = false;
                lblK.Visible = true;
                lblO.Visible = true;
                lblN.Visible = true;
                lblY.Visible = true;
                lblSH.Visible = true;
                lblE.Visible = true;
                lblV.Visible = true;
                timer16.Enabled = true;
            }
            else
            {
                lblTextProg3.Visible = true;
                btnPocClose.Visible = false;
                btnPocClose.Enabled = false;
                tbSrazyPoc.Visible = false;
                tbSrazyPoc.Enabled = false;
                btnPocOk.Visible = false;
                btnPocOk.Enabled = false;
                timer14.Enabled = true;
            }
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            timer17.Enabled = false;
            lblTextRast1.Visible = true;
            timer18.Enabled = true;
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            lblTextRast1.Visible = false;
            lblCount.Visible = true;
            btnBaraban3.Enabled = true;
            btnBaraban3.Visible = true;
            lblBarabanResult.Visible = true;
            lblNaBarabane.Visible = true;
            timer18.Enabled = false;
            btnSrazyRast.Visible = true;
            btnSrazyRast.Enabled = true;
        }

        private void btnBaraban3_Click(object sender, EventArgs e)
        {
            lblNaBarabane.Text = (new Random().Next(51)).ToString();
            btnBaraban3.Visible = false;
            btnBaraban3.Enabled = false;
            timer19.Enabled = true;
            btnSrazyRast.Visible = false;
            btnSrazyRast.Enabled = false;
        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = true;
            lblOchki.Visible = true;
            lblBukva.Visible = true;
            lblVyvodBar.Visible = true;
            lblVyvodBar.Text = lblNaBarabane.Text;
            timer19.Enabled = false;
            timer20.Enabled = true;
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            lblItak.Visible = false;
            lblOchki.Visible = false;
            lblBukva.Visible = false;
            lblVyvodBar.Visible = false;
            timer20.Enabled = false;
            button67.Visible = true;
            button68.Visible = true;
            button69.Visible = true;
            button70.Visible = true;
            button71.Visible = true;
            button72.Visible = true;
            button73.Visible = true;
            button74.Visible = true;
            button75.Visible = true;
            button76.Visible = true;
            button77.Visible = true;
            button78.Visible = true;
            button79.Visible = true;
            button80.Visible = true;
            button81.Visible = true;
            button82.Visible = true;
            button83.Visible = true;
            button84.Visible = true;
            button85.Visible = true;
            button86.Visible = true;
            button87.Visible = true;
            button88.Visible = true;
            button89.Visible = true;
            button90.Visible = true;
            button91.Visible = true;
            button92.Visible = true;
            button93.Visible = true;
            button94.Visible = true;
            button95.Visible = true;
            button96.Visible = true;
            button97.Visible = true;
            button98.Visible = true;
            button99.Visible = true;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            button98.Enabled = false;
            label9.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label9.Visible == true)
            {
                label16.Enabled = true;
                label15.Text = (int.Parse(label16.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            button94.Enabled = false;
            label10.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label10.Visible == true)
            {
                label17.Enabled = true;
                label15.Text = (int.Parse(label17.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            button74.Enabled = false;
            label11.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label11.Visible == true)
            {
                label18.Enabled = true;
                label15.Text = (int.Parse(label18.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            button81.Enabled = false;
            label12.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label12.Visible == true)
            {
                label19.Enabled = true;
                label15.Text = (int.Parse(label19.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            button75.Enabled = false;
            label13.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label13.Visible == true)
            {
                label20.Enabled = true;
                label15.Text = (int.Parse(label20.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            button99.Enabled = false;
            label14.Visible = true;
            lblCount.Text = (int.Parse(lblNaBarabane.Text) + int.Parse(lblCount.Text)).ToString();
            lblNaBarabane.Visible = false;
            lblTextProg2.Visible = true;
            timer21.Enabled = true;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
            if (label14.Visible == true)
            {
                label21.Enabled = true;
                label15.Text = (int.Parse(label21.Text) + int.Parse(label15.Text)).ToString();
            }
            if (label15.Text == "6")
            {
                timer24.Enabled = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                timer21.Enabled = false;
            }
        }

        private void timer21_Tick(object sender, EventArgs e)
        {
            timer21.Enabled = false;
            lblTextProg2.Visible = false;
            btnBaraban3.Visible = true;
            btnBaraban3.Enabled = true;
            lblNaBarabane.Visible = true;
            btnSrazyRast.Visible = true;
            btnSrazyRast.Enabled = true;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button97.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button96.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button95.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button78.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button93.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button92.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button91.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button90.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button89.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button88.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button80.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button77.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button87.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button86.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button85.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button84.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button83.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button82.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button79.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button76.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button73.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button72.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button71.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button70.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button69.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button68.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (lblCount.Text == "0")
            {
                timer22.Enabled = true;
                lblTextProg3.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
            }
            else
            {
                timer23.Enabled = true;
                lblTextProg4.Visible = true;
                lblNaBarabane.Visible = false;
                btnBaraban3.Visible = false;
                btnBaraban3.Enabled = false;
                lblCount.Text = "0";
            }
            button67.Enabled = false;
            button67.Visible = false;
            button68.Visible = false;
            button69.Visible = false;
            button70.Visible = false;
            button71.Visible = false;
            button72.Visible = false;
            button73.Visible = false;
            button74.Visible = false;
            button75.Visible = false;
            button76.Visible = false;
            button77.Visible = false;
            button78.Visible = false;
            button79.Visible = false;
            button80.Visible = false;
            button81.Visible = false;
            button82.Visible = false;
            button83.Visible = false;
            button84.Visible = false;
            button85.Visible = false;
            button86.Visible = false;
            button87.Visible = false;
            button88.Visible = false;
            button89.Visible = false;
            button90.Visible = false;
            button91.Visible = false;
            button92.Visible = false;
            button93.Visible = false;
            button94.Visible = false;
            button95.Visible = false;
            button96.Visible = false;
            button97.Visible = false;
            button98.Visible = false;
            button99.Visible = false;
        }

        private void timer22_Tick(object sender, EventArgs e)
        {
            timer22.Enabled = false;
            Close();
        }

        private void timer23_Tick(object sender, EventArgs e)
        {
            lblTextProg4.Visible = false;
            btnBaraban3.Visible = true;
            btnBaraban3.Enabled = true;
            lblNaBarabane.Visible = true;
            timer23.Enabled = false;
            btnSrazyRast.Visible = true;
            btnSrazyRast.Enabled = true;
        }

        private void timer24_Tick(object sender, EventArgs e)
        {
            timer17.Enabled = false;
            timer18.Enabled = false;
            timer19.Enabled = false;
            timer20.Enabled = false;
            timer21.Enabled = false;
            timer22.Enabled = false;
            timer23.Enabled = false;
            timer24.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban2.Visible = false;
            btnBaraban2.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            label15.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            btnSrazyRast.Visible = false;
            btnSrazyRast.Enabled = false;
            tbSrazyRast.Text = "";
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = true;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            выбратьДругуюТемуToolStripMenuItem2.Visible = false;
        }

        private void btnSrazyRast_Click(object sender, EventArgs e)
        {
            btnSrazyRast.Visible = false;
            btnSrazyRast.Enabled = false;
            btnBaraban3.Visible = false;
            btnBaraban3.Enabled = false;
            btnRastClose.Visible = true;
            btnRastClose.Enabled = true;
            tbSrazyRast.Visible = true;
            tbSrazyRast.Enabled = true;
            btnRastOk.Visible = true;
            btnRastOk.Enabled = true;
        }

        private void btnRastClose_Click(object sender, EventArgs e)
        {
            btnSrazyRast.Visible = true;
            btnSrazyRast.Enabled = true;
            btnBaraban3.Visible = true;
            btnBaraban3.Enabled = true;
            btnRastClose.Visible = false;
            btnRastClose.Enabled = false;
            tbSrazyRast.Visible = false;
            tbSrazyRast.Enabled = false;
            btnRastOk.Visible = false;
            btnRastOk.Enabled = false;
        }

        private void btnRastOk_Click(object sender, EventArgs e)
        {
            if (tbSrazyRast.Text == "БЕРЁЗА")
            {
                lblTextProg2.Visible = true;
                lblTextProg2.Text = "Поздравляем Вас с успешным завершением нашей игры! Вы можете выбрать следующую тему.";
                btnRastClose.Visible = false;
                btnRastClose.Enabled = false;
                tbSrazyRast.Visible = false;
                tbSrazyRast.Enabled = false;
                btnRastOk.Visible = false;
                btnRastOk.Enabled = false;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                timer24.Enabled = true;
            }
            else
            {
                lblTextProg3.Visible = true;
                btnRastClose.Visible = false;
                btnRastClose.Enabled = false;
                tbSrazyRast.Visible = false;
                tbSrazyRast.Enabled = false;
                btnRastOk.Visible = false;
                btnRastOk.Enabled = false;
                timer22.Enabled = true;
            }
        }

        private void выбратьДругуюТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            lblB.Visible = false;
            lblA.Visible = false;
            lblI.Visible = false;
            lblS.Visible = false;
            lblii.Visible = false;
            lblC.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban.Visible = false;
            btnBaraban.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            lblSlovoCount.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            tbSrazyProg.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            btnSrazyProg.Visible = false;
            btnSrazyProg.Enabled = false;
            выбратьДругуюТемуToolStripMenuItem.Visible = false;
        }

        private void выбратьДругуюТемуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer9.Enabled = false;
            timer10.Enabled = false;
            timer11.Enabled = false;
            timer12.Enabled = false;
            timer13.Enabled = false;
            timer14.Enabled = false;
            timer15.Enabled = false;
            timer16.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            pbGProg7.Visible = false;
            lblK.Visible = false;
            lblO.Visible = false;
            lblN.Visible = false;
            lblY.Visible = false;
            lblSH.Visible = false;
            lblE.Visible = false;
            lblV.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban2.Visible = false;
            btnBaraban2.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            label1.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            tbSrazyPoc.Text = "";
            btnSrazyPoc.Visible = false;
            btnSrazyPoc.Enabled = false;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button44.Enabled = true;
            button45.Enabled = true;
            button46.Enabled = true;
            button47.Enabled = true;
            button48.Enabled = true;
            button49.Enabled = true;
            button50.Enabled = true;
            button51.Enabled = true;
            button52.Enabled = true;
            button53.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;
            button61.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            выбратьДругуюТемуToolStripMenuItem1.Visible = false;
        }

        private void выбратьДругуюТемуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer17.Enabled = false;
            timer18.Enabled = false;
            timer19.Enabled = false;
            timer20.Enabled = false;
            timer21.Enabled = false;
            timer22.Enabled = false;
            timer23.Enabled = false;
            timer24.Enabled = false;
            List.Visible = false;
            lblTextProg1.Visible = false;
            lblTextProg2.Visible = false;
            lblTextProg3.Visible = false;
            lblTextProg4.Visible = false;
            pbGProg1.Visible = false;
            pbGProg2.Visible = false;
            pbGProg3.Visible = false;
            pbGProg4.Visible = false;
            pbGProg5.Visible = false;
            pbGProg6.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            lblCount.Visible = false;
            lblPlayerName1.Visible = false;
            pbPlayerStatus.Visible = false;
            btnBaraban3.Visible = false;
            btnBaraban3.Enabled = false;
            lblBarabanResult.Visible = false;
            lblNaBarabane.Visible = false;
            ThemeBack.Visible = true;
            lblVybor.Visible = true;
            btnProg.Visible = true;
            btnPoc.Visible = true;
            btnRast.Visible = true;
            btnProg.Enabled = true;
            btnPoc.Enabled = true;
            btnRast.Enabled = true;
            tbPName.Visible = true;
            tbPName.Enabled = true;
            tbPName.Text = "";
            lblEnterName.Visible = true;
            lblCount.Text = "0";
            lblNaBarabane.Text = "";
            label15.Text = "0";
            lblTextProg2.Text = "Совершенно верно! Крутите барабан дальше.";
            btnSrazyRast.Visible = false;
            btnSrazyRast.Enabled = false;
            tbSrazyRast.Text = "";
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = true;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            выбратьДругуюТемуToolStripMenuItem2.Visible = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();
            frm2.Show();
        }
    }
}

/* Group1
 Authors: Alyxander Byfield, Bernie Warren, Eric Thompson, Jung Hwa Hyun
 Creation Date: 2024/03/04
 Revision Date: 2024/03/20
 Description: FormGame, Initial form
 */

using DurakLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakClient
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        
        private void btnGameRules_Click(object sender, EventArgs e)
        {
            var RulesForm = new RulesForm();
            RulesForm.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (CheckStartability()) // Added parentheses to invoke the method
            {
                LaunchClient();
            }
        }

        private bool CheckStartability()
        {
            if (String.IsNullOrEmpty(txtName.Text)) 
            {
                MessageBox.Show("A Name must be entered to start the game");
                return false;
            }
            
            else
            {
                SetGameState();
                return true;
            }
        }

        private void SetGameState()
        {
            ClientSettings.Instance.PlayerName = txtName.Text;

            if (rbnDSize36.Checked) ClientSettings.Instance.GameDeckSize = 36;
            if (rbnDSize52.Checked) ClientSettings.Instance.GameDeckSize = 52;
;
        }

        private void LaunchClient()
        {
            var _ = new DurakGameForm();
            _.Show();

        }
    }
}

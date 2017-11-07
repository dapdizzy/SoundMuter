using RabbitMQSimpleReceiver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundMuter
{
    public partial class Form1 : Form
    {
        private SimpleReceiver receiver;

        public Form1()
        {
            InitializeComponent();

            receiver = new SimpleReceiver("rhino.rmq.cloudamqp.com", "ftudzxhj", "FojWUx6kp6-zFDtDT0tCkmFRQhcP7t-a", "ftudzxhj");
            receiver.MessageReceived += Receiver_MessageReceived;
            receiver.StartReceiving("MuteQueue");
        }

        private void Receiver_MessageReceived(object sender, MessageReceiverEventArgs e)
        {
            if (e.Message.ToUpperInvariant().Contains("MUTE"))
            {
                //MessageBox.Show("Mute message received");
                this.Invoke(new Action(() => ToggleMute(muteSound.Checked, true)));
                //ToggleMute(muteSound.Checked, true);
            }
        }

        private void setupButton()
        {
            muteSound.Text = "Mute Sound";
        }

        private void muteSound_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            ToggleMute(cb.Checked);
        }

        private void ToggleMute(bool toggle, bool setMode = false)
        {
            if (toggle)
            {
                this.Mute();
            }
            else
            {
                this.Mute();
            }

            if (setMode)
            {
                muteSound.CheckState = ToggleCheckState(toggle);
                //muteSound.Checked = toggle;
                muteSound.Refresh();
            }
        }

        private static CheckState ToggleCheckState(CheckState checkState)
        {
            CheckState oppositeState;
            switch (checkState)
            {
                case CheckState.Checked:
                    oppositeState = CheckState.Unchecked;
                    break;
                case CheckState.Unchecked:
                    oppositeState = CheckState.Checked;
                    break;
                default:
                    throw new InvalidOperationException($"CheckState value {checkState} is not supported");
            }
            return oppositeState;
        }

        private static CheckState ToggleCheckState(bool toggle)
        {
            return toggle ? CheckState.Checked : CheckState.Unchecked;
        }
    }
}

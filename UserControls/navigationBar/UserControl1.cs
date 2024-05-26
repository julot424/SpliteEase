using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navigationBar
{
    public partial class navigationBar: UserControl
    {
        private int startX;
        private int targetX;
        private float progress;
        private const int animationDuration = 500;
        private const int timeInterval = 15;

        public navigationBar()
        {
            InitializeComponent();
            AnimationTimer.Interval = timeInterval;
        }

        public event EventHandler AcceuilClicked;
        public event EventHandler ParticipantsClicked;
        public event EventHandler EvenementsClicked;
        public event EventHandler DepensesClicked;

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void lblAcceuil_Click(object sender, EventArgs e)
        {
            MoveIndicator(lblAcceuil);
            AcceuilClicked?.Invoke(this, e);
        }

        private void lblParticipant_Click(object sender, EventArgs e)
        {
            MoveIndicator(lblParticipant);
            ParticipantsClicked?.Invoke(this, e);
        }

        private void lblEvenement_Click(object sender, EventArgs e)
        {
            MoveIndicator(lblEvenement);
            EvenementsClicked?.Invoke(this, e);
        }

        private void lblDepense_Click(object sender, EventArgs e)
        {
            MoveIndicator(lblDepense);
            DepensesClicked?.Invoke(this, e);
        }

        private void MoveIndicator(Control label)
        {
            startX = picBoxIndicator.Location.X;
            targetX = label.Location.X + (label.Width / 2) - (picBoxIndicator.Width / 2);
            //targetX = label.Location.X;
            //picBoxIndicator.Width = label.Width;
            progress = 0;
            AnimationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            progress += (float)timeInterval / animationDuration;
            if (progress >= 1)
            {
                progress = 1;
                AnimationTimer.Stop();
            }

            float easedProgress = EaseInOut(progress);
            int newX = (int)(startX + (targetX - startX) * easedProgress);
            picBoxIndicator.Location = new Point(newX, picBoxIndicator.Location.Y);
        }

        private float EaseInOut(float t) 
        {
            return t < 0.5 ? 2 * t * t : -1 + (4 - 2 * t) * t;
        }
    }
}

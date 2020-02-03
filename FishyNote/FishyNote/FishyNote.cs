using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNote
{
    public partial class FishyNote : Form, IFishyNote
    {
        //Declaire a bool, called '_minimized' which checks if the window is minimazed, default value if set to false
        private bool _minimized = false;

        //Starting Height
        int _height;
        //Starting Width
        int _width;

        //Declaire an int, which represents id of the note, call it '_id'
        int _id;

        public FishyNote(Delegate delref)
        {
            InitializeComponent();
            //Setting main screen dimensions
            _height = this.Height;
            _width = this.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveNoteDeligate remDeligate = new RemoveNoteDeligate(delref.RemoveNote);
            //After button is pressed the window is closed
            remDeligate(_id);
            //The line above should replace the line bellow
            //this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if the window is already minimazed it should expand
            if (_minimized)
            {
                //Setting to default value of 470
                this.Height = _height;
                this.Width = _width;
                EnterText.Height = 327;
                //Setting to expanded state
                _minimized = false;
            }
            else
            {
                //If the window is not minimazed then shrink it
                this.Height = 100;
                this.Width = 150;
                EnterText.Height = 0;
                //Set it to minimazed state
                _minimized = true;
            }

        }

        //After the button is pressed reset the text
        private void EnterText_Click(object sender, EventArgs e)
        {
            EnterText.Text = "";
        }


        //Below there is the draging feature
        #region Code Snippet: makes this borderless window movable
        // Modified from https://stackoverflow.com/a/24561946 and attributed to user jay_t55

        // DECLARE a boolean that is set to true when a mouse down event is detected, call it _mouseDown:
        private bool _mouseDown = false;

        // DECLARE a Point object to store the last location of the window origin (ie memory), call it _lastLocation:
        private Point _lastLocation;

        // Mouse down event handler
        private void FishyNote_MouseDown_1(object sender, MouseEventArgs e)
        {
            // SET _mouseDown true:
            _mouseDown = true;

            // STORE current location to _lastLocation:
            _lastLocation = e.Location;
        }

        // Mouse move event handler
        private void FishyNote_MouseMove_1(object sender, MouseEventArgs e)
        {
            // Only act if mouse button is down...
            if (_mouseDown)
            {
                // SET new location according to mouse movement from _lastLocation:
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                // UPDATE this window:
                this.Update();
            }
        }

        // Mouse up event handler
        private void FishyNote_MouseUp_1(object sender, MouseEventArgs e)
        {
            // RESET _mouseDown to false:
            _mouseDown = false;
        }
        #endregion
        //Above there is the draging feature
    }
}

﻿/**
 * Copyright (c) 2010, Rob "N3X15" Nelson <nexis@7chan.org>
 *  All rights reserved.
 *
 *  Redistribution and use in source and binary forms, with or without 
 *  modification, are permitted provided that the following conditions are met:
 *
 *    * Redistributions of source code must retain the above copyright notice, 
 *      this list of conditions and the following disclaimer.
 *    * Redistributions in binary form must reproduce the above copyright 
 *      notice, this list of conditions and the following disclaimer in the 
 *      documentation and/or other materials provided with the distribution.
 *    * Neither the name of MineEdit nor the names of its contributors 
 *      may be used to endorse or promote products derived from this software 
 *      without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
 * IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
 * OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF 
 * LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE 
 * OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED 
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MineEdit.UIControls
{
    public partial class Dial : UserControl
    {
        private double mValue=0d;
        private double lineValue=0d;
        public double Value 
        {
            get 
            {
                return Lerp((mValue/360),Minimum,Maximum);
            }
            set 
            {
                mValue = ((OpenMinecraft.Utils.Clamp(value, Minimum, Maximum) - Minimum) / (Maximum - Minimum))*360;
                Invalidate();
            }
        }
        [DefaultValue(0d)]
        public double Minimum { get; set; }
        [DefaultValue(1d)]
        public double Maximum { get; set; }
        public string Label { get; set; }

        private PointF mCenter;
        public Dial()
        {
            InitializeComponent();
            Minimum = 0;
            Maximum = 1;
        }

        private double Lerp(double frac, double a, double b)
        {
            return a + (b - a) * frac;
        }

        private PointF ConvertToPoint(PointF offset, double angle, double radius)
        {
	        double radians = angle / (180.0 / 3.141952);
	        float x = offset.X + (float)((double)radius * Math.Cos(radians));
	        float y = offset.Y + (float)((double)radius * Math.Sin(radians));
	        PointF point = new PointF(x,y);
	        return point;
        }

        protected override void OnPaint(PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            bool DrawText = e.ClipRectangle.Height == e.ClipRectangle.Width && e.ClipRectangle.Width >= 64;
            Pen circlecolor = new Pen(Focused ? Color.Orange : SystemColors.ControlText,2f);

            DrawNightMarker(ref g);
            // Draw dial radius
            g.DrawEllipse(circlecolor, 2, 2, e.ClipRectangle.Width - 5, e.ClipRectangle.Width - 5);
            
            // Draw line at value
            mCenter = new PointF((ClientRectangle.Width / 2) - 1, (ClientRectangle.Width / 2) - 1);
            
            // Black = current value
            DrawAngle(ref g,lineValue, Pens.Red);
            // Red = mouse-driven value
            DrawAngle(ref g,mValue,circlecolor);

            // Draw Text
            StringFormat centerme = new StringFormat();
            centerme.Alignment = StringAlignment.Center;
            centerme.LineAlignment = StringAlignment.Center;

            string display = ((int)mValue).ToString()+"°\n"+((int)Value).ToString(); //string.Format("val:{0}\nmax:{1}", val, max);
            if(!string.IsNullOrEmpty(Label) && DrawText)
                display=Label+"\n"+display;
            g.DrawString(display, this.Font,SystemBrushes.ControlText,e.ClipRectangle,centerme);
            //g.Dispose();
        }

        /// <summary>
        /// Draw a transparent half-ellipse to mark the night side of the dial.
        /// </summary>
        /// <param name="g"></param>
        private void DrawNightMarker(ref Graphics g)
        {    // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.FromArgb(128,Color.Black));

            Rectangle rect = new Rectangle(2, 2, DisplayRectangle.Width - 5, DisplayRectangle.Width - 5);
            // Create start and sweep angles.
            float startAngle = 180.0F;
            float sweepAngle = 180.0F;

            // Fill pie to screen.
            g.FillPie(redBrush, rect, startAngle, sweepAngle);
        }

        private void DrawAngle(ref Graphics g, double ang,Pen c)
        {
            PointF inner = ConvertToPoint(mCenter, ang, (double)((ClientRectangle.Width / 2) - 6));
            PointF outer = ConvertToPoint(mCenter, ang, (double)((ClientRectangle.Width / 2)));

            g.DrawLine(c, inner, outer);
        }

        private void Dial_MouseDown(object sender, MouseEventArgs e)
        {
            // get mouse position
            double xpos = (double)e.X;
            double ypos = (double)e.Y;
            // calculate the center of the dial
            double xcenter = ClientRectangle.Width / 2;
            double ycenter = ClientRectangle.Width / 2;
            // subtract the center from the actual position to get the relative position to the midpoint
            xpos -= xcenter;
            ypos -= ycenter;

            double max = Maximum-Minimum;

            mValue = Math.Atan2(ypos, xpos) * (180.0 / Math.PI);
            mValue += mValue < 0 ? 360 : 0;
            //Invalidate();
        }
        double ConvertToAngle(PointF point, PointF center)
        {
	        //Calculate the position user click relative to the center
	        double x = point.X - center.X;
	        double y = point.Y - center.Y;

	        //Convert xy position to an angle.
	        return Math.Atan2(y, x);
        }

        private void Dial_MouseMove(object sender, MouseEventArgs e)
        {
            // get mouse position
            double xpos = (double)e.X;
            double ypos = (double)e.Y;
            // calculate the center of the dial
            double xcenter = ClientRectangle.Width / 2;
            double ycenter = ClientRectangle.Width / 2;
            // subtract the center from the actual position to get the relative position to the midpoint
            xpos = xpos-xcenter;
            ypos = ypos-ycenter;

            lineValue = Math.Atan2(ypos, xpos) *(180.0 / Math.PI);
            lineValue += lineValue < 0 ? 360 : 0;
            Invalidate();
        }
    }
}

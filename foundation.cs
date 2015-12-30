﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace GoldMine
    {
    public class Foundation : Container
        {
        public Foundation()
            {
            this.Background = Brushes.AntiqueWhite;
            }


        protected override Size ArrangeOverride( Size finalSize )
            {
            foreach( UIElement child in this.InternalChildren )
                {
                child.Arrange( new Rect( new Point( 0, 0 ), child.DesiredSize ) );
                }

            return finalSize;
            }
        }
    }

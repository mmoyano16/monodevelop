// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike KrÃ¼ger" email="mike@icsharpcode.net"/>
//     <version value="$version"/>
// </file>

using System;
using System.Diagnostics;
using System.Collections;
using Gtk;
using Gdk;
using Pango;
using System.Xml;

using MonoDevelop.Core;
using Mono.Addins;

namespace MonoDevelop.Core.Gui.Dialogs
{
	public class CurrentPanelPanel : DrawingArea
	{
//		WizardDialog wizard;
//		Pixbuf backGround = null;
		
//		FontDescription normalFont;
		
		public CurrentPanelPanel(WizardDialog wizard)
		{
//			normalFont = Style.FontDescription;

//			this.wizard = wizard;
			//backGround = resourceService.GetBitmap("GeneralWizardBackground");
			//RequestSize = new Size (wizard.Width - 220, 30);
		}
		/*
		
		protected override void OnPaintBackground(PaintEventArgs pe)
		{
			//    		base.OnPaintBackground(pe);
			Graphics g = pe.Graphics;
			//			g.FillRectangle(new SolidBrush(SystemColors.Control), pe.ClipRectangle);
			
			g.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(Width, Height),
			                                        Color.White,
			                                        SystemColors.Control),
			                                        new Rectangle(0, 0, Width, Height));
		}
		
		protected override void OnPaint(PaintEventArgs pe)
		{
			//    		base.OnPaint(pe);
/*
			Graphics g = pe.Graphics;
			g.DrawString(((IDialogPanelDescriptor)wizard.WizardPanels[wizard.ActivePanelNumber]).Label, normalFont, Brushes.Black,
			             10,
			             24 - normalFont.Height,
			             StringFormat.GenericTypographic);
			g.DrawLine(Pens.Black, 10, 24, Width - 10, 24);
 
		}*/
	}
}

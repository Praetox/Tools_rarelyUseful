using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VirtuaPad
{
    public class LabelArray : System.Collections.CollectionBase
    {
        private readonly System.Windows.Forms.Form HostForm;

        /* Declare in main form:
         * LabelArray lTiles;
         * public static Label tileClicked;
         * public static int tileClickedNum;
         */

        public System.Windows.Forms.Label NewLabel()
        {
            // Create a new instance of the Label class.
            System.Windows.Forms.Label aLabel = new System.Windows.Forms.Label();
            // Add the label to the collection's internal list.
            this.List.Add(aLabel);
            // Add the label to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aLabel);
            // Set intial properties for the label object.
            aLabel.Top = Count * 25;
            aLabel.Left = 100;
            aLabel.Tag = this.Count;
            aLabel.Text = "Label " + this.Count.ToString();
            aLabel.Click += new System.EventHandler(ClickHandler);
            return aLabel;
        }

        // The constructor hack
        public LabelArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            this.NewLabel();
        }

        // The default property
        public System.Windows.Forms.Label this[int Index]
        {
            get
            {
                return (System.Windows.Forms.Label)this.List[Index];
            }
        }

        // The remove method
        public void Remove()
        {
            // Check to be sure there is a label to remove.
            if (this.Count > 0)
            {
                // Remove the last label added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        // Our goal - the common event handler
        public void ClickHandler(Object sender, System.EventArgs e)
        {
            frmMain.lInfClicked = ((System.Windows.Forms.Label)sender);
            frmMain.lInfClickedNum = Convert.ToInt32(((System.Windows.Forms.Label)sender).Tag.ToString());
        }
    }

    public class PBoxArray : System.Collections.CollectionBase
    {
        private readonly System.Windows.Forms.Form HostForm;

        /* Declare in main form:
         * PBoxArray pSpr;
         * public static PictureBox sprClicked;
         * public static int sprClickedNum;
         */

        public System.Windows.Forms.PictureBox NewPBox()
        {
            // Create a new instance of the pbox class.
            System.Windows.Forms.PictureBox aPBox = new System.Windows.Forms.PictureBox();
            // Add the pbox to the collection's internal list.
            this.List.Add(aPBox);
            // Add the pbox to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aPBox);
            // Set intial properties for the pbox object.
            aPBox.Top = Count * 25;
            aPBox.Left = 100;
            aPBox.Tag = this.Count;
            aPBox.Click += new System.EventHandler(ClickHandler);
            return aPBox;
        }

        // The constructor hack
        public PBoxArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            this.NewPBox();
        }

        // The default property
        public System.Windows.Forms.PictureBox this[int Index]
        {
            get
            {
                return (System.Windows.Forms.PictureBox)this.List[Index];
            }
        }

        // The remove method
        public void Remove()
        {
            // Check to be sure there is a pbox to remove.
            if (this.Count > 0)
            {
                // Remove the last pbox added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        // Our goal - the common event handler
        public void ClickHandler(Object sender, System.EventArgs e)
        {
            frmMain.pGlowClicked = ((System.Windows.Forms.PictureBox)sender);
            frmMain.pGlowClickedNum = Convert.ToInt32(((System.Windows.Forms.PictureBox)sender).Tag.ToString()); ;
        }
    }

    public class PanelArray : System.Collections.CollectionBase
    {
        private readonly System.Windows.Forms.Form HostForm;

        /* Declare in main form:
         * PanelArray pPnl;
         * public static Panel pnlClicked;
         * public static int pnlClickedNum;
         */

        public System.Windows.Forms.Panel NewPanel()
        {
            // Create a new instance of the Panel class.
            System.Windows.Forms.Panel aPanel = new System.Windows.Forms.Panel();
            // Add the Panel to the collection's internal list.
            this.List.Add(aPanel);
            // Add the Panel to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aPanel);
            // Set intial properties for the Panel object.
            aPanel.Top = Count * 25;
            aPanel.Left = 100;
            aPanel.Tag = this.Count;
            aPanel.Click += new System.EventHandler(ClickHandler);
            return aPanel;
        }

        // The constructor hack
        public PanelArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            this.NewPanel();
        }

        // The default property
        public System.Windows.Forms.Panel this[int Index]
        {
            get
            {
                return (System.Windows.Forms.Panel)this.List[Index];
            }
        }

        // The remove method
        public void Remove()
        {
            // Check to be sure there is a Panel to remove.
            if (this.Count > 0)
            {
                // Remove the last Panel added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        // Our goal - the common event handler
        public void ClickHandler(Object sender, System.EventArgs e)
        {
            frmMain.pPadClicked = ((System.Windows.Forms.Panel)sender);
            frmMain.pPadClickedNum = Convert.ToInt32(((System.Windows.Forms.Panel)sender).Tag.ToString()); ;
        }
    }
}

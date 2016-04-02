﻿using System;
using System.Drawing;
using System.Linq;

using Foundation;
using UIKit;

using SQLite;
using System.Collections.Generic;

namespace IOS_BancoDados
{
    public partial class RootViewController : UIViewController
    {
        public RootViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var db = new SQLiteConnection("DB");

            db.CreateTable<Cliente>();

            db.Insert(new Cliente() { Nome = "cliente1" });
            db.Insert(new Cliente() { Nome = "cliente2" });

            List<Cliente> CLIS = db.Table<Cliente>().ToList();



        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }
}
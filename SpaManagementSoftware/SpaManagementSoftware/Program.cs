﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace SpaManagementSoftware
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            UserLookAndFeel.Default.SetSkinStyle("Summer 2008");
            /*Caramel,Money Twins,Lilian,The Asphalt World,iMaginary,Black,Blue,Coffee,Liquid Sky,London Liquid Sky,Glass Oceans,Stardust
             * Xmas 2008 Blue,Valentine,McSkin,Summer 2008,Pumpkin,Dark Side,Springtime,Darkroom,Foggy,High Contrast,Seven,Seven Classic
             * Sharp,Sharp Plus,DevExpress Style,Office 2007 Blue,Office 2007 Black,Office 2007 Silver,Office 2007 Green,Office 2007 Pink,Office 2010 Blue
             * Office 2010 Black,Office 2010 Silver*/       
            Application.Run(new frmMain());
        }
    }
}

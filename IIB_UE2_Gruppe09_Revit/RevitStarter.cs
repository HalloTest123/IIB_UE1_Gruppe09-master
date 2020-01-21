using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using System.IO;
using System.Windows.Media.Imaging;

namespace IIB_UE2_Gruppe09_Revit
{
    public class RevitStarter : IExternalApplication
    {
        #region attributes
        static string thisAssemblyPath = typeof(RevitStarter).Assembly.Location;
        #endregion

        #region Interface methods
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // Creates the ribbon panel in revit on startup
            try
            {
                createRibbonPanel(application);
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                TaskDialog.Show("Fire Drencher Addin", e.ToString());
                return Result.Failed;
            }
        }
        #endregion

        #region Methods
        private void createRibbonPanel(UIControlledApplication application)
        {
            String panelName = "MyAddins";
            RibbonPanel ribbonDemoPanel = application.CreateRibbonPanel(panelName);
            PushButton myButton = (PushButton)ribbonDemoPanel.AddItem(new PushButtonData("Fire Drencher", "Fire Drencher Tool", thisAssemblyPath, typeof(RevitStarter).FullName));
            string ButtonIconsFolder = Path.GetDirectoryName(thisAssemblyPath);
            myButton.LargeImage = new BitmapImage(new Uri(Path.Combine(ButtonIconsFolder, "Ressources\fireDrencher.png"), UriKind.Absolute));
            myButton.ToolTip = "Click here to start the FireDrencher Tool.";
        }
        #endregion
    }
}

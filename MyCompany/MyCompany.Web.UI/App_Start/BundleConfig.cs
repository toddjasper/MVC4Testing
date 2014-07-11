﻿using System.Web.Optimization;

namespace MyCompany.Web.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            // ##############################################################################################################################
            // JAVASCRIPT
            // ##############################################################################################################################

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Resources/scripts/jquery/jquery-1.10.2.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquery-uncompressed").Include("~/Resources/scripts/jquery-uncompressed/jquery-1.11.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/mycompany").Include("~/Resources/scripts/custom/user-info.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery-mobile").Include("~/Resources/scripts/jquery-mobile/jquery.mobile.custom.js"));

            //bundles.Add(new ScriptBundle("~/bundles/imageviewer").Include("~/Resources/scripts/imageviewer/owl.carousel.js"));

            //bundles.Add(new ScriptBundle("~/bundles/kendo").Include("~/Resources/scripts/kendo/kendo.all.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.aspnetmvc.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/kendo").Include("~/Resources/scripts/kendo/jquery.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.core.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.web.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.window.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.datetimepicker.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.dropdownlist.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.grid.min.js",
            //                                                        "~/Resources/scripts/kendo/kendo.aspnetmvc.min.js"));

            // ##############################################################################################################################
            // CSS
            // ##############################################################################################################################

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Resources/css/homepage.css",
                                                                 "~/Resources/css/products.css",
                                                                 "~/Resources/css/viewer.css",
                                                                 "~/Resources/css/core.css",
                                                                 "~/Resources/css/finance.css"));

            //bundles.Add(new StyleBundle("~/Content/jquery-mobile").Include("~/Resources/css/jquery-mobile/jquery.mobile.custom.structure.css",
            //                                                               "~/Resources/css/jquery-mobile/jquery.mobile.custom.theme.css"));

            //bundles.Add(new StyleBundle("~/Content/imageviewer").Include("~/Resources/css/owl.carousel.css",
            //                                                                "~/Resources/css/owl.theme.css",
            //                                                                "~/Resources/css/product.css"));

            //bundles.Add(new StyleBundle("~/Content/kendo").Include("~/Resources/css/kendo/kendo.common.core.min.css",
            //                                                       "~/Resources/css/kendo/kendo.common.min.css",
            //                                                       "~/Resources/css/kendo/kendo.black.min.css"));
        }
    }
}
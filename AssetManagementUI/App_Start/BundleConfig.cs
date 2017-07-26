using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AssetManagementUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Script Bundle
            // base design header script
            bundles.Add(new ScriptBundle("~/bundles/head").Include(
                "~/BaseDesignAssets/js/ace-extra.min.js"));

            // base design footer script
            bundles.Add(new ScriptBundle("~/bundle/jquery").Include(
                "~/BaseDesignAssets/js/jquery-2.1.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/BaseDesignAssets/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ace").Include(
                "~/BaseDesignAssets/js/ace-elements.min.js",
                "~/BaseDesignAssets/js/ace.min.js"));



            // Css Bundle
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/BaseDesign/css").Include(
                "~/BaseDesignAssets/css/bootstrap.min.css",
                "~/BaseDesignAssets/font-awesome/4.5.0/css/font-awesome.min.css",
                "~/BaseDesignAssets/css/fonts.googleapis.com.css",
                "~/BaseDesignAssets/css/ace.min.css",
                "~/BaseDesignAssets/css/ace-skins.min.css",
                "~/BaseDesignAssets/css/ace-rtl.min.css"));
        }
    }
}
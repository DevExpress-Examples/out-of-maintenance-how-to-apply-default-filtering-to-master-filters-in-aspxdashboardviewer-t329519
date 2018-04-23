using System;
using System.Linq;
using DevExpress.DashboardCommon;

namespace Dashboard_MFDefaultValues {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_SingleFilterDefaultValue(object sender, 
            SingleFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "gridDashboardItem1") {
                var lauraCallahan = e.GetAvailableSelections().First(v => (string)v["Sales Person"] == "Laura Callahan");
                e.SetFilterValue(lauraCallahan);       
            }
        }

        protected void ASPxDashboardViewer1_FilterElementDefaultValues(object sender, 
            FilterElementDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "treeViewDashboardItem1") {
                e.FilterValues.Clear();
                var beveragesProducts = e.AvailableFilterValues.Where(v => (string)v["Category"] == "Beverages");
                beveragesProducts.ToList().ForEach(i => e.FilterValues.Add(i));
                e.FilterValues.Add(e.AvailableFilterValues.First(v => (string)v["Product"] == "Aniseed Syrup"));
            }
        }

        protected void ASPxDashboardViewer1_RangeFilterDefaultValue(object sender, 
            RangeFilterDefaultValueEventArgs e) {
            if (e.DashboardItemName == "rangeFilterDashboardItem1") {
                e.Range = new RangeFilterSelection(new DateTime(2015, 06, 01), new DateTime(2016, 04, 01));
            }
        }
    }
}
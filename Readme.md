<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Dashboard_MFDefaultValues/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_MFDefaultValues/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_MFDefaultValues/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_MFDefaultValues/WebForm1.aspx.vb))
<!-- default file list end -->
# How to apply default filtering to master filters in ASPxDashboardViewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t329519)**
<!-- run online end -->


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example shows how to apply default filtering to master filter items using <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewerMembersTopicAll">API</a> of <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebASPxDashboardViewertopic">ASPxDashboardViewer</a>. In this example, default filtering is applied to the following dashboard items.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_MasterFilterDefaultValuestopic">MasterFilterDefaultValues</a> event is handled to apply filtering to <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument15150">Grid</a> and <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument17659">Tree View</a>.<br>- The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_RangeFilterDefaultValuetopic">RangeFilterDefaultValue</a> event is used to select the specified date range in the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument15265">Range Filter</a>.

<br/>



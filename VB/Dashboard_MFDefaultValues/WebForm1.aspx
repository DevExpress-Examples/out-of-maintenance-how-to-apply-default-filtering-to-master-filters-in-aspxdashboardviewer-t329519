﻿<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" Inherits="Dashboard_MFDefaultValues.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            DashboardSource="Dashboard_MFDefaultValues.Dashboard1" FullscreenMode="True" 
            Height="100%" 
            onfilterelementdefaultvalues="ASPxDashboardViewer1_FilterElementDefaultValues" 
            onrangefilterdefaultvalue="ASPxDashboardViewer1_RangeFilterDefaultValue" 
            onsinglefilterdefaultvalue="ASPxDashboardViewer1_SingleFilterDefaultValue" 
            Width="100%">
        </dx:ASPxDashboardViewer>
    </div>
    </form>
</body>
</html>
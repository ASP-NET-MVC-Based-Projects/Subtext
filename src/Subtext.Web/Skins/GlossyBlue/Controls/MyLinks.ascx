<%@ Control Language="c#" Inherits="Subtext.Web.UI.Controls.MyLinks" %>
<%@ Register TagPrefix="SP" Namespace="Subtext.Web.Controls" Assembly="Subtext.Web.Controls" %>
<div id="menu">
    <ul>
	    <li><asp:HyperLink Runat="server" Text="Home" ID="HomeLink" /></li>
	    <li><asp:HyperLink AccessKey="9" Runat="server" Text="Contact" ID="ContactLink" /></li>
	    <li><asp:HyperLink Runat="server" Text="Admin" ID="Admin" /></li>
    </ul>
</div>
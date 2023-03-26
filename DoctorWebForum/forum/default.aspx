<%-- DEFAULT LANDING PAGE --%>
<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="True" EnableViewState="false" Inherits="aspnetforum.forums" MasterPageFile="AspNetForumMaster.Master" %>
<%@ Register TagPrefix="cc" TagName="RecentPosts" Src="recentposts.ascx" %>


<asp:Content ContentPlaceHolderID="AspNetForumContentPlaceHolder" ID="AspNetForumContent" runat="server">
	<asp:Repeater ID="rptGroupsList" Runat="server" EnableViewState="False" OnItemDataBound="rptGroupsList_ItemDataBound">
		<ItemTemplate>
			<table style="width:100%;" class="roundedborder biglist">
				<tr><th colspan="2"><h2><%# Eval("GroupName") %></h2></th><th class="mobilehidden"><%= aspnetforum.Resources.various.Threads %></th><th class="mobilehidden"><%= aspnetforum.Resources.various.LatestPost %></th></tr>
				<tbody>
			<asp:repeater id="rptForumsList" runat="server" EnableViewState="False">
				<ItemTemplate>
					<tr <%# Container.ItemType == ListItemType.AlternatingItem ? " class='altItem'" : "" %> >
						<td align="center" style="width:10%;border-right:none;"><img alt="" src="<%# GetForumIcon(Eval("IconFile")) %>" height="32" width="32" /></td>
						<td style="width:55%;border-left:none;padding-left: 0;"><h2>
							<a href='<%# aspnetforum.Utils.Various.GetForumURL(Eval("ForumID"), Eval("Title")) %>'><%# Eval("Title") %></a>
							</h2>
							<span class="gray2"><%# Eval("Description") %></span>
						</td>
						<td width="50" class="gray2 mobilehidden" style="text-align: center">
							<%# Eval("TopicCount") %></td>
						<td style="white-space:nowrap" class="gray2 mobilehidden">
							<%# aspnetforum.Utils.Topic.GetTopicInfoBMessageyID(Eval("LatestMessageID"), Cmd)%></td>
					</tr>
				</ItemTemplate>
			</asp:repeater>
			</table>
		</ItemTemplate>
		<FooterTemplate></tbody></FooterTemplate>
	</asp:Repeater>
	<div ID="lblNoForums" style="margin-top:20px;" runat="server" visible="false" enableviewstate="false"><%= aspnetforum.Resources.various.NoForums %></div>
	<div id="divNoForumsAdmin" style="margin-top:20px;" runat="server" visible="false">No forums have been created yet. Please go to the <a href="admin.aspx">administrator panel</a>.</div>

	<div id="divRecent" runat="server" enableviewstate="false" visible="false">
	<br />
	<cc:RecentPosts id="recentPosts" runat="server"></cc:RecentPosts>
	</div>
</asp:Content>
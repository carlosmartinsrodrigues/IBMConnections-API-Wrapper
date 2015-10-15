<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
  <script type="text/javascript" src="../Scripts/jquery-2.1.4.min.js"></script>   
  <script type="text/javascript" src="../Scripts/connectionsClient.js"></script>
  <script type="text/javascript" src="/_layouts/15/sp.runtime.js"></script>
  <script type="text/javascript" src="/_layouts/15/sp.js"></script>
  <meta name="WebPartPageExpansion" content="full" />

 <%-- <!-- breeze & dependent libraries -->
  <script type="text/javascript" src="../Scripts/q.js"></script>
  <script type="text/javascript" src="../Scripts/breeze.debug.js"></script>
  <script type="text/javascript" src="../Scripts/breeze.labs.dataservice.abstractrest.js"></script>
  <script type="text/javascript" src="../Scripts/breeze.labs.dataservice.sharepoint.js"></script>
  <script type="text/javascript" src="../Scripts/breeze.metadata-helper.js"></script>--%>

  <!-- Add your CSS styles to the following file -->
  <link rel="Stylesheet" type="text/css" href="../Content/App.css" />

  <%--<script type="text/javascript" src="../Scripts/sbt/dojo/dojo.js" djConfig="parseOnLoad: true"></script>
  <script type="text/javascript" src="../Scripts/library?lib=dojo&ver=1.8.0"></script>--%>

  <!-- Add your JavaScript to the following file -->
  <script type="text/javascript" src="../Scripts/connectionsClient.js"></script>
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
  SharePoint 2013 + Connections Sample
</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">

   <div class="tabordion">
  <section id="section1">
    <input type="radio" name="sections" id="searchOption" checked>
    <label for="searchOption">Search Profile</label>
    <article>      
      <div class="box">
         <div class="search-businesscard">
            <input type="search" id="search" placeholder="Search..." />
            <button id="ibm-search" class="fa">search</button>
         </div>
      </div>
      <div id="searchresults"></div>
    </article>
  </section>
  
  <section id="section2">
    <input type="radio" name="sections" id="myStatusOption">
    <label for="myStatusOption">My Status</label>
    <article>
       <div class="box">
         <div class="search-businesscard">
           <input type="text" id="statusUpdate" placeholder="Status Update..." />
            <button id="ibm-statusUpdate" class="fa">Post new status</button>
         </div>
      </div>
      <div id="MyStatusResults"></div>
    </article>
  </section>
  
</div>


</asp:Content>

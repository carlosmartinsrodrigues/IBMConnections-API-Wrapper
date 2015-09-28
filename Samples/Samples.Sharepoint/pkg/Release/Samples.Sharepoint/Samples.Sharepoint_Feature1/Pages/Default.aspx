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
    <input type="radio" name="sections" id="option1" checked>
    <label for="option1">John Lennon</label>
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
    <input type="radio" name="sections" id="option2">
    <label for="option2">Paul McCartney</label>
    <article>
      <h2>Paul McCartney</h2>
      <p>Sir James Paul McCartney, (born 18 June 1942), is an English musician, singer, songwriter, multi-instrumentalist, and composer. With John Lennon, George Harrison and Ringo Starr, he gained worldwide fame as a member of the Beatles, widely regarded as one of the most popular and influential acts in the history of rock music; his songwriting partnership with Lennon is one of the most celebrated of the 20th century. After the band's break-up, he pursued a solo career and later formed Wings with his first wife, Linda, and Denny Laine.</p>
      <p>McCartney has been recognised as one of the most successful composers and performers of all time, with 60 gold discs and sales of over 100 million albums and 100 million singles of his work with the Beatles and as a solo artist.[2] More than 2,200 artists have covered his Beatles song "Yesterday", more than any other copyrighted song in history. Wings' 1977 release "Mull of Kintyre" is one of the all-time best-selling singles in the UK. Inducted into the Rock and Roll Hall of Fame as a solo artist in March 1999, McCartney has written, or co-written 32 songs that have reached number one on the Billboard Hot 100, and as of 2014 he has sold more than 15.5 million RIAA-certified units in the United States. McCartney, Lennon, Harrison and Starr received MBEs in 1965, and in 1997, McCartney was knighted for his services to music.</p>
      <p>McCartney has released an extensive catalogue of songs as a solo artist and has composed classical and electronic music. He has taken part in projects to promote international charities related to such subjects as animal rights, seal hunting, land mines, vegetarianism, poverty, and music education. He has married three times and is the father of five children.</p>
    </article>
  </section>
  <section id="section3">
    <input type="radio" name="sections" id="option3">
    <label for="option3">George Harrison</label>
    <article>
      <h2>George Harrison</h2>
      <p>George Harrison, (25 February 1943 – 29 November 2001), was an English musician, multi-instrumentalist, singer and songwriter who achieved international fame as the lead guitarist of the Beatles. Although John Lennon and Paul McCartney were the band's primary songwriters, most of their albums included at least one Harrison composition, including "While My Guitar Gently Weeps", "Here Comes the Sun" and "Something", which became the Beatles' second-most-covered song.</p>
    </article>
  </section>
  <section id="section4">
    <input type="radio" name="sections" id="option4">
    <label for="option4">Ringo Starr</label>
    <article>
      <h2>Ringo Starr</h2>
      <p>Richard Starkey, (born 7 July 1940), better known by his stage name Ringo Starr, is an English musician, singer, songwriter, and actor who gained worldwide fame as the drummer for The Beatles. On most of the band's albums, he sang lead vocals for one song, including "With a Little Help from My Friends", "Yellow Submarine" and their cover of "Act Naturally". He also wrote the Beatles' songs "Don't Pass Me By" and "Octopus's Garden", and is credited as a co-writer of others, such as "What Goes On" and "Flying".</p>
      <p>Starr was twice afflicted by life-threatening illnesses during his childhood, and as a result of prolonged hospitalisations, fell behind scholastically. In 1955, he entered the workforce and briefly held a position with British Rail before securing an apprenticeship at a Liverpool equipment manufacturer. Soon afterwards, he became interested in the UK skiffle craze, developing a fervent admiration for the genre. In 1957, he cofounded his first band, the Eddie Clayton Skiffle Group, which earned several prestigious local bookings before the fad succumbed to American rock and roll by early 1958.</p>
    </article>
  </section>
</div>


</asp:Content>

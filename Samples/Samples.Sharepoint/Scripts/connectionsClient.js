var ibmConnectionsClient =(function() { 
	var service = {};
	//need to enable cors
	/*http://connections.swg.usma.ibm.com/wikis/home?lang=en#!/wiki/Wd9526250d913_4ab4_bf9c_a80e9deb0916/page/IBM%20Connections%20API%20CORS%20Support
	*/
	//http://dubxpcvm073.mul.ie.ibm.com/blogs/oauth/atom/blogs
	var domainUrl="https://dubxpcvm1192.mul.ie.ibm.com:9444";
	var username="Ajones1";
	var password="jones1";
	

	function make_base_auth() {
	   var tok = username + ':' + password;
	   var hash = btoa(tok);
	   return "Basic " + hash;
	}
  

	service.PerformSearch = function (searchString) {
       $.support.cors = true;
       var _url = domainUrl + '/profiles/atom/search.do?name=' + searchString;
		  
	   $.ajax({
		type: "GET",
		url: _url,
		dataType: "xml",
		xhrFields: { withCredentials: true },
		
		success: function(xml){
			$(xml).find('entry').each(function(){
			   var sTitle = $(this).find('Title').text();
			   var sId = $(this).find('id').text()
			   sId = sId.replace("tag:profiles.ibm.com,2006:entry", "");
			  var card = $(this).find('content').html();
			  $("<div class='container-businesscard'></div>").html(sTitle + "<br/><a class='followUser' rel='" + sId + "' >Click to follow</a><br /> " + card).appendTo("#searchresults");
			}); 
		},
		error: function(err) {
			console.log(err);
			//alert("An error occurred while processing XML file.");
		}
	  });

	}

	service.StartFollowing = function (userId) {
	   $.support.cors = true;
	   var _url = domainUrl + '/profiles/follow/atom/resources';

	   $.ajax({
	      type: "POST",
	      url: _url,
	      dataType: "xml",
	      xhrFields: { withCredentials: true },
	      data: { key: userId, connectionType: "colleague" },
	      beforeSend: function (xhr) {
	         xhr.setRequestHeader("Authorization", "Basic " + make_base_auth());
	      },
	      success: function (xml) {
	         $(xml).find('entry').each(function () {
	            var sTitle = $(this).find('Title').text();

	            var card = $(this).find('content').html();
	            $("<div class='container-businesscard'></div>").html(sTitle + "<br /> " + card).appendTo("#searchresults");
	         });
	      },
	      error: function (err) {
	         console.log(err);
	         //alert("An error occurred while processing XML file.");
	      }
	   });

	}

	service.PeopleFollowing = function () {
	   $.support.cors = true;
	   var _url = domainUrl + '/profiles/follow/atom/resources?type=Profile&source=profiles&inclMessage=True&inclUserStatus=True';
	   $("#followingresults").empty();
	   $.ajax({
	      type: "GET",
	      url: _url,
	      dataType: "xml",
	      xhrFields: { withCredentials: true },
        beforeSend: function(xhr) {
           xhr.setRequestHeader("Authorization", "Basic " + make_base_auth());
           },
        success: function (xml) {
           console.log(xml);
           $(xml).find('entry').each(function () {
              console.log($(this).find('title'));
              var sTitle = $(this).find('title').text();
              var sId = $(this).find('id').text().replace("urn:lsid:ibm.com:follow:resource-","");
              var sImage = "<img src='" + domainUrl + "/profiles/photo.do?key=" + sId + "' class='photo'>";
              $("<div class='container-businesscard'></div>").html(sImage+"<br/>"+sTitle).appendTo("#followingresults");
	         });
	      },
	      error: function (err) {
	         console.log(err);
	         //alert("An error occurred while processing XML file.");
	      }
	   });

	}

	service.ShowStatus = function () {
	   $.support.cors = true;
	   var _url = domainUrl + '/profiles/atom/mv/theboard/entries/all.do';
	   
	   $.ajax({
	      type: "GET",
	      url: _url,
	      dataType: "xml",
	      xhrFields: { withCredentials: true },
	      beforeSend: function (xhr) {
	         xhr.setRequestHeader("Authorization", "Basic " + make_base_auth());
	      },
	      success: function (xml) {
	         $("#MyStatusResults").empty();
	         $(xml).find('entry').each(function () {
	            var sAuthor = $(this).find('author').find('name').text();
	            var sId = $(this).find('author').find('userid').text();
	            var sPublished = $(this).find('published').text();
	            var sTitle = $(this).find('title').text();
	            var sId = $(this).find('id').text().replace("urn:lsid:ibm.com:follow:resource-", "");
	            var sImage = "<img src='" + domainUrl + "/profiles/photo.do?key=" + sId + "' class='photo'>";
	            $("<div class='container-status'></div>").html("<div class='statuswrapper'><div class='image'>" + sImage + "</div><div class='status'>" + sTitle + "<br/>" + sAuthor + "<br/>" + sPublished).appendTo("#MyStatusResults");
	         });
	      },
	      error: function (err) {
	         console.log(err);
	         //alert("An error occurred while processing XML file.");
	      }
	   });

	}
	service.UpdateStatus = function (message) {
	   $.support.cors = true;
	   var _url = domainUrl + '/profiles/atom/mv/theboard/entries/related.do';

	   $.ajax({
	      type: "GET",
	      url: _url,
	      dataType: "xml",
	      xhrFields: { withCredentials: true },
	      beforeSend: function (xhr) {
	         xhr.setRequestHeader("Authorization", "Basic " + make_base_auth());
	      },
	      success: function (xml) {
	         $(xml).find('entry').each(function () {
	            var sTitle = $(this).find('Title').text();
	            var card = $(this).find('content').html();
	            $("<div class='container-businesscard'></div>").html(sTitle + "<br /> " + card).appendTo("#searchresults");
	         });
	      },
	      error: function (err) {
	         console.log(err);
	         //alert("An error occurred while processing XML file.");
	      }
	   });

	}

	return service;
}());

$(document).ready(function () {
   $("#ibm-search").click(function (event) {
      event.preventDefault(); // cancel default behavior
      ibmConnectionsClient.PerformSearch($("#search").val());
   })
  
   $("#searchresults").on('click', '.followUser', function () {
      ibmConnectionsClient.StartFollowing($(this).attr("rel"));
   });
   $("#ibm-statusUpdate").click(function (event) {
      event.preventDefault(); // cancel default behavior     
      ibmConnectionsClient.UpdateStatus($("#statusUpdate").val());
   })
   $("#myStatusOption").click(function (event) {
      ibmConnectionsClient.ShowStatus();
   })

});
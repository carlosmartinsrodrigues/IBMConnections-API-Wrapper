var ibmConnectionsClient =(function() { 
	var service = {};
	//need to enable cors
	/*http://connections.swg.usma.ibm.com/wikis/home?lang=en#!/wiki/Wd9526250d913_4ab4_bf9c_a80e9deb0916/page/IBM%20Connections%20API%20CORS%20Support
	*/
	//http://dubxpcvm073.mul.ie.ibm.com/blogs/oauth/atom/blogs
	var domainUrl="https://dubxpcvm1192.mul.ie.ibm.com:9444";
	var username="Ajones1";
	var password="jones1";
	

   /*
   beforeSend: function(xhr) {
			xhr.setRequestHeader("Authorization", "Basic " + btoa(username + ":" + password));
		},*/

	service.PerformSearch = function (searchString) {
       $.support.cors = true;
       var _url = domainUrl + '/profiles/atom/search.do?name=' + searchString;
		  
	   $.ajax({
		type: "GET",
		url: _url,
		dataType: "xml",
		xhrFields: { withCredentials: true },
		
		success: function(xml){
			console.log(xml);
			$(xml).find('entry').each(function(){
			  var sTitle = $(this).find('Title').text();
			  var card = $(this).find('content').html();
			  $("<div class='container-businesscard'></div>").html(sTitle + "<br /> " + card).appendTo("#searchresults");
			});
		},
		error: function(err) {
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
	//console.log("ready");
	//console.log(ibmConnectionsClient);
	

});
﻿/*
These global variables must be set before this script is loaded

_rcBaseUrl: URL of the RC website home page. This should be an absolute URL without the trailing /
_rcItemsUrl: URL which will return the json array of RC items. This should be a relative to _rcBaseUrl and must begin with /
*/

$(document).ready(function () {
    $("#footermenu").toolbar({ theme: "a" });
});

// Get a list of items available on the release candidate site and show the RC link for each of the items available
$(document).on('pagecreate', '#mainpage', function () {
    if (!_rcBaseUrl) {
        // No RC URL specified. Nothing to do
    }
    $.ajax(_rcBaseUrl + _rcItemsUrl, {
        dataType: 'jsonp',
        crossDomain: true
    }).done(function (data, textStatus, jqXHR) {
        // The call to RC was successful. Show the RC link at the bottom of the page
        $('#rcNavBar small').hide();
        // Show the rc link against each menu items
        $.each(data, function () {
            $('#' + this.area).attr('href', _rcBaseUrl + this.url).show();
        });
    }).fail(function (jqXHR, textStatus, errorThrown) {
        $('#linkRc small').text('Contact failed with error ' + jqXHR.status);
    });
}).on("pagecontainershow", function (event, ui) {
    // Code taken from View source of page http://demos.jquerymobile.com/1.4.3/toolbar-fixed-persistent/
    // Find the id of the page which is currently active
    var curpageId = $("div.ui-page-active").attr('id');
    //alert(curpageId);
    // Remove active class from nav buttons
    $("#navbarFixed a.ui-btn-active").removeClass("ui-btn-active");
    // Add active class to nav button of current page.
    // We find the button whose href points to the id of the current page
    $("#navbarFixed a[href='#" + curpageId + "']").addClass("ui-btn-active");
});


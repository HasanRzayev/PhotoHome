

var ajaxCallUrl = '/Home/ImageList',
    page = 0,
    inCallback = false,
    isReachedScrollEnd = false;


var scrollHandler = function () {
    if (isReachedScrollEnd == false &&
        ($(document).scrollTop() <= $(document).height() - $(window).height())) {
        loadProducts(ajaxCallUrl);
    }
}
function loadProducts(ajaxCallUrl) {
    if (page > -1 && !inCallback) {
        inCallback = true;
        page++;
  
        $.ajax({
            type: 'GET',
            url: ajaxCallUrl,
            data: "pageNumber=" + page,
            success: function (data, textstatus) {
                if (data != '') {
                    $("divajaxCall").append(data);
                    alert("bbbb");
                }
                else {
                    page = -1;
                }

                inCallback = false;
                
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    }
}  



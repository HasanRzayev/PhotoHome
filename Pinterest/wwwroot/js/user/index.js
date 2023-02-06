
var get_span = (ele) => {
    downloadImage(ele.id, "Image");
    var option = ele.id;

    $.ajax({
        type: "POST",
        url: "/Home/Download",
        data: { Link: String(option) },
        success: function () {
            $("#contact_form").html("<div id='message'></div>");
            $("#message")
                .html("<h2>Contact Form Submitted!</h2>")
                .append("<p>We will be in touch soon.</p>")
                .hide()
                .fadeIn(1500, function () {
                    $("#message").append(
                        "<img id='checkmark' src='images/check.png' />"
                    );
                });
        }
    });

    function downloadImage(url, name) {
        fetch(url)
            .then(resp => resp.blob())
            .then(blob => {
                const url = window.URL.createObjectURL(blob);
                const a = document.createElement('a');
                a.style.display = 'none';
                a.href = url;
                a.download = name;
                document.body.appendChild(a);
                a.click();
                window.URL.revokeObjectURL(url);
            })
    }

}


var animateButton = function (e) {
    e.preventDefault;
    e.target.classList.remove('animate');

    e.target.classList.add('animate');
    setTimeout(function () {
        e.target.classList.remove('animate');
    }, 700);
};

var bubblyButtons = document.getElementsByClassName("bubbly-button");


var likeClick = (obj) => {
    var option = obj.id;

    $.ajax({
        type: "POST",
        url: "/Home/Like",
        data: { Link: String(option) },
        success: function () {
            $("#contact_form").html("<div id='message'></div>");
            $("#message")
                .html("<h2>Contact Form Submitted!</h2>")
                .append("<p>We will be in touch soon.</p>")
                .hide()
                .fadeIn(1500, function () {
                    $("#message").append(
                        "<img id='checkmark' src='images/check.png' />"
                    );
                });
        }
    });

    obj.classList.toggle("redHeart")
}


var RemoveClick = (obj) => {
    var option = obj.id;
    $(".card-columns").children().remove($(".card-columns").children().find(option))
    $.ajax({
        type: "POST",
        url: "/Home/RemoveImage",
        data: { Link: String(option) },
        success: function () {
            $("#contact_form").html("<div id='message'></div>");
            $("#message")
                .html("<h2>Contact Form Submitted!</h2>")
                .append("<p>We will be in touch soon.</p>")
                .hide()
                .fadeIn(1500, function () {
                    $("#message").append(
                        "<img id='checkmark' src='images/check.png' />"
                    );
                });
        }
    });

    obj.classList.toggle("redHeart")
}

//!

$(document).ready(function () {
    console.log("ready!");
});


for (var i = 0; i < bubblyButtons.length; i++) {
    bubblyButtons[i].addEventListener('click', animateButton, false);
}


var ajaxCallUrl = '/Home/ImageList',
    page = 0,
    inCallback = false,
    isReachedScrollEnd = false;



var url = '/Home/Download',
    page = 0,
    inCallback = false,
    isReachedScrollEnd = false;





var scrollHandler = function () {

    var height = $(Window).scrollTop();
    if (isReachedScrollEnd == false &&
        (height >= $(document).height() -1000)) {
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
                    console.log(data);
                    for (var i = 0; i < data.length; i++) {
                        console.log(data[i])
                        var clone = $("#image_card:last-child").clone();
                        clone.children("img").attr('src', data[i]);
                        clone.find('span[class="DownloadButton"]').attr('id', data[i]);

                        clone.appendTo("#divajaxCall");
                    }

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











//const image_card_Click = (obj) => {
//    alert($(obj).children("img").attr('src'))
//    var option = $(obj).children("img").attr('src')
//    $(obj).children("heart").prop('name', option);
//}



//$("#image_card").click(function () {

//    alert("span clicked");
//});










//$("i[name = 'down_icon']").click(function (evt) {

//    downloadImage(evt.target.id, "Image");
//    var option = evt.target.id;
//    console.log(evt.target.id)
//    $.ajax({
//        type: "POST",
//        url: url,
//        data: { Link: String(option) },
//        success: function () {
//            $("#contact_form").html("<div id='message'></div>");
//            $("#message")
//                .html("<h2>Contact Form Submitted!</h2>")
//                .append("<p>We will be in touch soon.</p>")
//                .hide()
//                .fadeIn(1500, function () {
//                    $("#message").append(
//                        "<img id='checkmark' src='images/check.png' />"
//                    );
//                });
//        }

//    });



//    function downloadImage(url, name) {
//        fetch(url)
//            .then(resp => resp.blob())
//            .then(blob => {
//                const url = window.URL.createObjectURL(blob);
//                const a = document.createElement('a');
//                a.style.display = 'none';
//                a.href = url;
//                a.download = name;
//                document.body.appendChild(a);
//                a.click();
//                window.URL.revokeObjectURL(url);
//            })
//            .catch(() => alert('An error sorry'));
//    }





//});





//$(".DownloadButton").click(function (evt) {

//    downloadImage(evt.target.id, "Image");
//    var option = evt.target.id;

//    $.ajax({
//        type: "POST",
//        url: url,
//        data: { Link: String(option) },
//        success: function () {
//            $("#contact_form").html("<div id='message'></div>");
//            $("#message")
//                .html("<h2>Contact Form Submitted!</h2>")
//                .append("<p>We will be in touch soon.</p>")
//                .hide()
//                .fadeIn(1500, function () {
//                    $("#message").append(
//                        "<img id='checkmark' src='images/check.png' />"
//                    );
//                });
//        }

//    });

//    function downloadImage(url, name) {
//        fetch(url)
//            .then(resp => resp.blob())
//            .then(blob => {
//                const url = window.URL.createObjectURL(blob);
//                const a = document.createElement('a');
//                a.style.display = 'none';
//                a.href = url;
//                a.download = name;
//                document.body.appendChild(a);
//                a.click();
//                window.URL.revokeObjectURL(url);
//            })
//    }
//});







//$(this).children('input[name="down_icon"]').click(function (e) {
//    downloadImage(e).target.id, "Image";
//var option = e.target.id;

//    $.ajax({
//        type: "POST",
//        url: url,
//        data: { Link: String(option) },
//        success: function () {
//            $("#contact_form").html("<div id='message'></div>");
//            $("#message")
//                .html("<h2>Contact Form Submitted!</h2>")
//                .append("<p>We will be in touch soon.</p>")
//                .hide()
//                .fadeIn(1500, function () {
//                    $("#message").append(
//                        "<img id='checkmark' src='images/check.png' />"
//                    );
//                });
//        }

//    });


//    function downloadImage(url, name) {
//        fetch(url)
//            .then(resp => resp.blob())
//            .then(blob => {
//                const url = window.URL.createObjectURL(blob);
//                const a = document.createElement('a');
//                a.style.display = 'none';
//                a.href = url;
//                a.download = name;
//                document.body.appendChild(a);
//                a.click();
//                window.URL.revokeObjectURL(url);
//            })
//            .catch(() => alert('An error sorry'));
//    }


//});
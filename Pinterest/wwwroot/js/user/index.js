

var animateButton = function (e) {
    e.preventDefault;
    e.target.classList.remove('animate');

    e.target.classList.add('animate');
    setTimeout(function () {
        e.target.classList.remove('animate');
    }, 700);
};



var bubblyButtons = document.getElementsByClassName("bubbly-button");

$("#find").click(function () {

    var option = $(this).val();
    if (option.length === 0) {
        $.ajax({
            type: "GET",
            url: "/Home/Search",
            data: { search: String(option) },
            success: function (data) {


                if (data != '' && option != "") {

                  
                    const list = document.getElementById("divajaxCall");

                    for (var i = 0; i < $("#divajaxCall").children().length - 2; i++) {
                        list.removeChild(list.firstChild);
                    }

                    for (var i = 0; i < data.length; i++) {
                        console.log(data[i])
                       
                        var clone = $("#image_card:last-child").clone();
                        clone.children("img").attr('src', data[i]);
                        clone.find('span[class="DownloadButton"]').attr('id', data[i]);
                        clone.insertAfter("#image_card");



                        //    clone.children("img").attr('src', data[i]);
                        //    clone.find('span[class="DownloadButton"]').attr('id', data[i]);

                        //clone.show()
                        //appendTo("#divajaxCall");
                    }
                    list.removeChild(list.firstElementChild);
                }



            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {


                $("#divajaxCall").empty();
            }


        });
    }
  




});

let get_span = (ele) => {

    downloadImage(ele.id, "Image");
    var option = ele.id;

    $.ajax({
        type: "POST",
        url: "/Home/Download",
        data: { Link: String(option) },
        success: function () {
            alert("good")
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
            .catch(() => alert('An error sorry'));
    }

}

//!

const likeClick = (obj) => {
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
    alert(obj.target.id)
}



const RemoveClick = (obj) => {
    var option = obj.id;

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
    alert(obj.target.id)
}


//!

$('.owl-carousel').owlCarousel({
    autoplay: true,
    autoplayTimeout: 1750,
    //autoplayHoverPause: true,
    loop: true,
    margin: 10,
    nav: true,
    responsive: {
        0: {
            items: 6
        },
        768: {
            items: 7
        },
        1000: {
            items: 8
        }
    }
})

$('.owl-prev').html('<span><i class="fa-solid fa-chevron-left"></i></span>')
$('.owl-next').html('<span><i class="fa-solid fa-chevron-right"></i></span>')

//different colored category carousel
var arr = $('#category-carousel .item').children()

$.each(arr, (index) => {
    var colorR = Math.floor((Math.random() * 200));
    var colorG = Math.floor((Math.random() * 200));
    var colorB = Math.floor((Math.random() * 200));

    $(arr[index]).css("background-color", "rgb(" + colorR + "," + colorG + "," + colorB + ")")
})






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



//var url = '/Home/Download',
//    page = 0,
//    inCallback = false,
//    isReachedScrollEnd = false;





//var scrollHandler = function () {

//    var height = $(Window).scrollTop();
//    if (isReachedScrollEnd == false &&
//        (height >= $(document).height() -1000)) {
//        loadProducts(ajaxCallUrl);
//    }
//}





//function loadProducts(ajaxCallUrl) {
//    if (page > -1 && !inCallback) {
//        inCallback = true;
//        page++;
  
//        $.ajax({
//            type: 'GET',
//            url: ajaxCallUrl,
//            data: "pageNumber=" + page,
//            success: function (data, textstatus) {
//                if (data != '') {
//                    console.log(data);
//                    for (var i = 0; i < data.length; i++) {
//                        console.log(data[i])
//                        var clone = $("#image_card:last-child").clone();
//                        clone.children("img").attr('src', data[i]);
//                        clone.find('span[class="DownloadButton"]').attr('id', data[i]);
                      
//                        clone.appendTo("#divajaxCall");
//                    }

//                }
//                else {
//                    page = -1;
//                }

//                inCallback = false;
                
//            },
//            error: function (XMLHttpRequest, textStatus, errorThrown) {
//                alert(errorThrown);
//            }
//        });
//    }
//}  











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





    $(".DownloadButton").click(function (evt) {
       
        downloadImage(evt.target.id, "Image");
        var option = evt.target.id;
        alert(evt.target.id)
        $.ajax({
            type: "POST",
            url: url ,
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
                .catch(() => alert('An error sorry'));
        }





    });







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
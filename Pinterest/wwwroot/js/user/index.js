
var animateButton = function (e) {
    e.preventDefault;
    e.target.classList.remove('animate');

    e.target.classList.add('animate');
    setTimeout(function () {
        e.target.classList.remove('animate');
    }, 700);
};




var bubblyButtons = document.getElementsByClassName("bubbly-button");




for (var i = 0; i < bubblyButtons.length; i++) {
    bubblyButtons[i].addEventListener('click', animateButton, false);
}


//Sekillerin yuklenmesi ucun method

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
//Sekillerin Like olunmasi  ucun method


var likeClick = (obj) => {
    var option = obj.id;
    $(`#${option}`).remove();
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


//Create  sekillerin  silinmesi  ucun method

var RemoveClick = (obj) => {
    var option = obj.id;

    var parent = obj.parentNode.parentNode.parentNode;
 
    parent.remove();
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

$('select').bsSelectDrop({
    btnWidth: 'fit-content',
    btnEmptyText: 'Select An Option...',
    btnClass: 'btn btn-outline-secondary',
});


//Home page  lazy loading code



var ajaxCallUrl = '/Home/ImageList',
    page = 0,
    inCallback = false,
    isReachedScrollEnd = false;



var scrollHandler = function () {

    var height = $(Window).scrollTop();
    if (isReachedScrollEnd == false &&
        (height >= $(document).height() / 2)) {
        loadProducts(ajaxCallUrl);
    }
}

var search_type = 'This is a string value';
var category = 'This is a string value';

function loadProducts(ajaxCallUrl) {
    if (page > -1 && !inCallback) {
        inCallback = true;
        page++;

        serach_type="category"
        $.ajax({
            type: 'GET',
            url: ajaxCallUrl,
            data: { pageNumber: page, search: category, search_type: search_type },
            success: function (data, textstatus) {
                if (data != '') {
                    data = data.replaceAll('class="card"', 'class="card img-loaded"');
                    //data = data.replaceAll('probootstrap-animate', 'probootstrap-animate fadeInUp probootstrap-animated');
                    data = data.replaceAll('</div><br/>', '<br/>');
                    data = data.replaceAll('<div class="image-column">', ' ');
                    arr = data.split('<br/>');
                    console.log(arr[0])
                    console.log(arr[1])
                    console.log(arr[2])
                  
                    var children = $("#divajaxCall").children(".image-column").eq(0);

                    $(arr[0]).appendTo(children);

                    var children = $("#divajaxCall").children(".image-column").eq(1);

                    $(arr[1]).appendTo(children);

                    var children = $("#divajaxCall").children(".image-column").eq(2);

                    $(arr[2]).appendTo(children);
                   
                    /* $("#element").get(0).classList.add("new-class");*/
                    $("#divajaxCall").find("img").addClass("fadeInUp");
                    $("#divajaxCall").find("img").addClass("probootstrap-animated");

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
//Taglarin  gonderilmesi

function sendData() {
    var items = [];
    $("#tagUl li").map(function () {
        items.push(this.innerText);
    });

    $.ajax({
        type: "POST",
        data: {
            list: items
        },
        url: "/Home/AddTag",
        success: function (res) {
            alert("a")
        }
    })
}
        

var ul = document.getElementById("tagUl");
var input = document.getElementById("tagInput");
var tags = ["salam"];


createTag();


function createTag() {
    ul.querySelectorAll("li").forEach(li => li.remove());
    tags.slice().reverse().forEach(tag => {
        let liTag = `<li>${tag} <i class="uit uit-multiply" onclick="remove(this, '${tag}')"></i></li>`;
        ul.insertAdjacentHTML("afterbegin", liTag);
    });
   
}

function remove(element, tag) {
    let index = tags.indexOf(tag);
    tags = [...tags.slice(0, index), ...tags.slice(index + 1)];
    element.parentElement.remove();
   
}

function addTag(e) {
    if (e.keyCode === 32) {
        let tag = e.target.value.replace(/\s+/g, ' ');

        if (tag.length > 1 && !tags.includes(tag)) {
            tag.split(',').forEach(tag => {
                tags.push(tag);
                createTag();
                
            });
        }
        e.target.value = "";

    }
}

input.addEventListener("keypress", addTag);





//Sekillerin yuklenmesi


$(".DownloadButton").click(function (evt) {

    downloadImage(evt.target.id, "Image");
    var option = evt.target.id;

    $.ajax({
        type: "POST",
        url: url,
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


////!

//const draggerArea = document.getElementById('dragger');
//const inputField = document.getElementById('fileInputField');
//const dragText = document.getElementById('drag-text');
//const fileDelete = document.getElementById('fileDelete');
//const browseFile = document.getElementById('browseFile');
//const textarea = document.getElementById('textarea');

//const inputClick = () => {
//    inputField.value = ""
//    inputField.click();
//};

//inputField.addEventListener('change', function (e) {
//    file = this.files[0];
//    fileHandler(file);
//});

//draggerArea.addEventListener('dragover', (e) => {
//    e.preventDefault()
//    dragText.textContent = "Release to upload image"
//});

//draggerArea.addEventListener('dragleave', () => {
//    dragText.textContent = "Drag and drop file"
//});

//draggerArea.addEventListener('drop', (e) => {
//    e.preventDefault()
//    file = e.dataTransfer.files[0];
//    fileHandler(file)
//});

//const deleteHandler = () => {
//    const draggerElement = `<div class="icon"><i class="fa-solid fa-images"></i></div><h3 id="drag-text">Drag and drop file</h3><button class="browseFile py-1 px-3" id="browseFile" onclick="inputClick()">Browse</button><input type="file" hidden id="fileInputField"/>`;
//    draggerArea.innerHTML = draggerElement
//    draggerArea.classList.remove('active');
//};

//const fileHandler = (file) => {
//    const validExt = ["image/jpeg", "image/jpg", "image/png"]
//    if (validExt.includes(file.type)) {
//        const fileReader = new FileReader();
//        fileReader.onload = () => {
//            const fileURL = fileReader.result
//            // textarea.innerHTML = fileURL;
//            //const encrypted = sjcl.encrypt("salt", fileURL);
//            //console.log(encrypted);
//            // console.log(fileURL)
//            let imgTag = `<img src=${fileURL} alt=""/><div id="fileDelete"><i class="fa-solid fa-trash-can" onclick={deleteHandler()}></i></div>`
//            draggerArea.innerHTML = imgTag;
//        }
//        fileReader.readAsDataURL(file);
//        draggerArea.classList.add('active')
//    } else {
//        draggerArea.classList.remove('active');
//        dragText.textContent = "Drag drop file"
//    }
//};







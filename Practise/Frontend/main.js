/* window.addEventListener('load', function () {
   let btn =  document.getElementById("showText");
   btn.addEventListener("click", showOrHideText);

function showOrHideText() {
    let paragraphs = document.getElementsByTagName("p");
    let myP = paragraphs[0];

console.log(myP.classList.contains("hide"));

if (myP.classList.contains("hide")) {
    //so menuvanje na klasi
    myP.classList.remove("hide");
    myP.classList.add("show");

    //so menuvanje na css
    myP.classList.display = "block";


} else {
    myP.classList.remove("show");
    myP.classList.add("hide")
}

}
}, false);*/


$(document).ready(function () {
    $("p")[0].style.display = "none";

    $("#showText").click(function () {
        let paragraphs = $("p");
        let myP = paragraphs[0];

        if (myP.style.display == "none") {
            myP.style.display = "block";
        } else {
            myP.style.display = "none";
        }
    });

$.ajax(
    {
        url: 'resources/myText.txt',
        success: function (result) {
            console.log(result);
            $("#funAjax").html(result);
        },
        error: function (ex) {
            console.log("sorry the data cannot be reached!");
        }
    }


);
});








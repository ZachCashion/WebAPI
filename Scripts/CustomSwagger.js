$(function () {

    //Change the default Swagger text
    $("#logo").html("&nbsp; &nbsp; WebAPI")

    //Turning off the text box
    $("input[name='baseUrl'], input[name='apiKey']").css("display", "none");

    //Custom icon
    $("link[type='image/png']").attr("href", "/favicon.ico");

    //Custom Title
    $("title").text("WebAPI")

    //Custom Button Hide
    $("#explore").css("display", "none")
})
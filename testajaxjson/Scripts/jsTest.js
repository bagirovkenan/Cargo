$(function () {

    

    $("#catName").change(function () {
      
      $.ajax({
            url: "/Products/UserTasks",
            type: "Get",
            data: "id=" + $(this).val(),
           
            success: function (result) {


               

                if (result.length > 0) {
                    $(".prodiv").show();
                }
                else {
                    $(".prodiv").hide();

                  
                }



                $("#pro").html(" ");

                /*$.each(result, function (key, task)*/
                for (var i = 0; i < result.length;i++)
                {
                    var ss = '<option value="' + result[i].Id + '">' + result[i].ProductName+'</option>'


                    $("#pro").append(ss);
                    console.log(ss);

                }

            }

        })
    })
})
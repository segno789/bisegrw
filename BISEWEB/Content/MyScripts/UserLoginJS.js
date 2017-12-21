
       jQuery(document).ready(function () {
            
           Metronic.init(); // init metronic core components
           Layout.init(); // init current layout
           Demo.init();
           $("#btnLogin").click(function () {
               debugger;
               if ($("#txtLogin").val() == "")
               {
                   toastr.error("Enter Employee Code Please !", "Wrong Input")
                   //alert("Enter Employee Code Please !");
                   $("#txtLogin").focus();
                   return false;
               }
               if ($("#txtPassword").val() == "") {
                   toastr.error("Enter Password Please !", "Wrong Input")
                   //alert("Enter Password Please !");
                   $("#txtPassword").focus();
                   return false;
               }
               return true;
           })
       });
$("#txtPassword").focus(function () {
            
    var id = $("#txtLogin").val();
    if(id=="")
    {
        toastr.error("Enter Emloyee Code First !", "Wrong Input")
        //alert("Enter Emloyee Code First !");
        $("#txtLogin").focus();
        $("#txtPassword").val()="";
        return false
    }
    $.ajax({
        url: "/api/MyWebAPI/GetNameByID/" + id,
        type: "POST",
        // data: '{id: "' + $("#txtLogin").val() + '" }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response == "") {
                toastr.error("Employee Code Is Not Valid !", "Wrong Input")
                // alert("Employee Code Is Not Valid !")
                $("#txtLogin").show();
                $("#txtLogin").focus();
                return false;
            }
            var resp = response.split("|");
            $('#EmpName').html(resp[0]);
            if (resp[1] == "True") {
                $('#EmpImg').attr('src', '/Content/EmpImages/' + id + '.jpg');
            }
            else {
                $('#EmpImg').attr('src', '/Content/EmpImages/no-image.png');
            }
            return false;
        },
        failure: function (response) {
            toastr.error("", "Failure")
            //alert("Failure");
        },
        error: function (response) {
            toastr.error(response.responseText, "Failure")
            //alert("Error" + response.responseText);
        }
    });

});
$("#txtLogin").keypress(function (e) {
    if (e.which == 13) {
        $("#txtPassword").focus();
        return false
    }
});


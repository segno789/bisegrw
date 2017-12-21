


jQuery(document).ready(function () {
            //var val = @Session["Redirect"];
            //if (val == "1") {
            //    window.location.href = ("http://localhost:54394/Home/Contact?Length=4");
            //    $.ajax('/Home/ClearSession');
            //}
            $('li').removeClass('active');
            $('li').removeClass('open');
            var url = window.location;
            $('a').filter(function () {
                return this.href == url;
            }).parent().parent().parent().addClass('active open');
            $('a').filter(function () {
                return this.href == url;
            }).parent().addClass('active open')
            Metronic.init();
            Layout.init();
            QuickSidebar.init();
            Demo.init();
            //UIIdleTimeout.init();
           // UIToastr.init();

            $(function () {
                var fnTimeOut = function () {

                    jQuery.timeoutDialog.setupDialogTimer({
                        timeout: 1,
                        countdown: 20,
                        logout_redirect_url: '@Url.Action("Logout", "Home")',
                        keep_alive_url: '@Url.Action("Keepalive", "Home")'
                    });
                };
                fnTimeOut();
            });

        });













var loginUrl='@Url.Action("UserLogin", "User")';
var extendMethodUrl='@Url.Action("ExtendSession","User")';
$(document).ready(function(){
    SessionTimeout.schedulePopup();

});

window.SessionTimeout = (function() {
    var _timeLeft, _popupTimer, _countDownTimer;
    var stopTimers = function() {
        window.clearTimeout(_popupTimer);
        window.clearTimeout(_countDownTimer);
    };
    var updateCountDown = function() {
        var min = Math.floor(_timeLeft / 60);
        var sec = _timeLeft % 60;
        if(sec < 10)
            sec = "0" + sec;

        document.getElementById("CountDownHolder").innerHTML = min + ":" + sec;

        if(_timeLeft > 0) {
            _timeLeft--;
            _countDownTimer = window.setTimeout(updateCountDown, 1000);
        } else  {
            document.location = loginUrl;
        }
    };
    var showPopup = function() {
        $("#divPopupTimeOut").show();
        _timeLeft = 60;
        updateCountDown();
    };
    var schedulePopup = function() {
        $("#divPopupTimeOut").hide();
        stopTimers();
        _popupTimer = window.setTimeout(showPopup, @PopupShowDelay);
    };
    var hidePopup=function(){
       

        $("#divPopupTimeOut").hide();
        window.location.href= loginUrl;
    };
    var sendKeepAlive = function() {
      
        stopTimers();
        $("#divPopupTimeOut").hide();
        $.ajax({
            type: "GET",
            url: extendMethodUrl,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function successFunc(response) {
                SessionTimeout.schedulePopup();
            },
            error:function(){
            }
        });
    };
    return {
        schedulePopup: schedulePopup,
        sendKeepAlive: sendKeepAlive,
        hidePopup:hidePopup,
        stopTimers:stopTimers,
    };

})();
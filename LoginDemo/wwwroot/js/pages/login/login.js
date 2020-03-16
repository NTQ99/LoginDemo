$(document).ready(function () {
    var login = new Login();
    $('#loginForm').on('submit', login.checkPassword);
});
/**
 * Web login
 * AUTHOR: NTQ (16/03/2020)
 * */
class Login {
    constructor() { };
    checkPassword() {
        var obj = $('#loginForm').serializeArray();
        var data = {
            "Username": obj[0].value,
            "Password": obj[1].value
        }
        $.ajax({
            type: 'GET',
            url: `https://localhost:44394/api/login/${data.Username}/${data.Password}`,
            success: function (res) {
                res = (res === true) ? "Login succesful!" : "Login fail!";
                alert(res)
            }
        });
    };
}
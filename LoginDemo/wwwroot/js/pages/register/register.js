$(document).ready(function () {
    var login = new Login();
    $('#registerForm').on('submit', login.checkPassword);
});
/**
 * Web login
 * AUTHOR: NTQ (16/03/2020)
 * */
class Login {
    constructor() { };
    checkPassword() {
        var obj = $('#registerForm').serializeArray();
        var data = {
            "Username": obj[0].value,
            "Password": obj[1].value
        }
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44394/api/login',
            dataType: 'json',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (res) {
                res = (res === true) ? "Login succesful!" : "Login unsuccesful!";
                alert(res)
            }
        });
    };
}
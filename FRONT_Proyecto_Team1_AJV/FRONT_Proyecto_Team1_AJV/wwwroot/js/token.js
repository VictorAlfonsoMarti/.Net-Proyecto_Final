// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CallToken(user, password) {
    // Función para guardar el token con el user y pass pasado por parámetro
    $.ajax({
        url: "http://www.userstrabajadoresnet.somee.com/API/TokenUsers",
        method: 'POST',
        dataType: 'json',
        headers: {
            'Accept': 'application/json',
        },
        contentType: 'application/json',
        data: JSON.stringify({
            'email': user,
            'userPassword': password
        }),

        success: function (data) {
            localStorage.setItem('token', 'Bearer ' + data);
        },
        error: function (error) {
            if (error.responseText != "Invalid credentials") {
                localStorage.setItem('token', 'Bearer ' + error.responseText);
            }
        }
    });
}
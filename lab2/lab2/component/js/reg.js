$("#btnSubmit").click(function (e) {
    $.ajax({
        type: "POST",
        url: "/Register/Register",
        data: {
            firstName: $("#firstname").val(),
            lastName: $("#lastname").val(),
            email: $("#email").val(),
            pass: $("#pass").val()
        },
        success: function (result) {
            alert(firstName, lastName, email, pass);
            console.log(firstName, lastName, email, pass);
        }
    });
    
});

$("#bt").click(function (e) {
    alert("Треееш");
});
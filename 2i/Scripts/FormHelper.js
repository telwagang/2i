window.onload = function () {
    var d = Formio.createForm(document.getElementById('formio'), 'https://klxqsnqpyanjlgh.form.io/user/register',
        {
            hooks: {
                beforeSubmit: (submission, next) => {
                    console.log("submited before");
                    console.log(submission);
                    InsertData(submission.data)
                        .then(() => {
                            next();
                        })
                        .catch((e) => {
                            next([{message:e}]);
                        });
                }
            }
        });
    d.then(function (form) {
        form.on('submitDone', function (v) {
            console.log("submited");
            console.log(v);
        });
        form.on('error', function (x) {
            console.log(x);
        });

    });
    //this.console.log(d);
};

function InsertData(data) {
    return new Promise(function (resolve, reject) {

        UTILS.Post('/api/Forms/Insert', data,
            function (d) {
            reject(new Error(d.error));
        }, function (v) {
            resolve(v);
        });
    });


}

var UTILS =
{
    Post: function (url, params, failure, success) {
        $.ajax({
            type: "POST",
            async: true,
            url: url,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(params),
            success: success,
            error: failure

        });
    }
};
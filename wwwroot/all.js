window.allJsFunction = {
    login: function (token)
    {
        localStorage.setItem("token", token);
        return 0;
    }
};
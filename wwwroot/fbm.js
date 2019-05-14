window.FBMJsFunction = {
    setLocalStorage: function (key, value)
    {
        localStorage.setItem(key, value);
        return 0;
    },

    getLocalStorage: function (key)
    {
        return localStorage.getLocalStorage(key);
    }
};
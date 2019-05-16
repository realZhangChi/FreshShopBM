window.FBMJsFunction = {
    setLocalStorage: function (key, value) {
        localStorage.setItem(key, value);
        return 0;
    },

    getLocalStorage: function (key) {
        return localStorage.getLocalStorage(key);
    },

    getFileData: function() {
        let img = document.getElementById("fileUpload");
        let file = img.files[0];
        let data;
        let reader = new FileReader();
        reader.onload = function (e) {
            data = e.target.result; // 'data:image/jpeg;base64,/9j/4AAQSk...(base64编码)...'   
                // console.log(data);
        };
        // 以DataURL的形式读取文件:
        let result = reader.readAsDataURL(file);
        console.log(result);
        // alert("check");
        // return data;
        // const temporaryFileReader = new FileReader();
        // return new Promise((resolve, reject) => {
        //     temporaryFileReader.onerror = () => {
        //         temporaryFileReader.abort();
        //         reject(new DOMException("Problem parsing input file."));
        //     };
        //     temporaryFileReader.addEventListener("load", function () {
        //         var data = {
        //             content: temporaryFileReader.result.split(',')[1]
        //         };
        //         resolve(data);
        //     }, false);
        //     temporaryFileReader.readAsDataURL(inputFile.files[0]);
        // });
    }
};
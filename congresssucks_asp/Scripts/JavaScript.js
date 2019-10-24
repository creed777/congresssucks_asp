    tinymce.init({
        selector: "#LongPost",
        height: 500,
        margin: "auto"

});

    function Short()
    {
            //alert(tinymce.activeEditor.getContent())
            var text = tinymce.activeEditor.getContent();
        document.getElementById('ShortPost').value = text.substring(0, 100);
    }

    function UpdateDT()
    {
            //alert("fuckyou DT")
            var dt = new Date()
        document.getElementById('Update').value = dt.toLocaleDateString("en-US")
    }
    
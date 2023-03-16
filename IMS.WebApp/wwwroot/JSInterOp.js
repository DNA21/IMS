function PreventFormSubmition(formId) {

    document.getElementById(`${formId}`).addEventListener("keydown", function (event) {

        if (event.code == "Enter") {
            event.preventDefault();
            return false;
        }
    });
}
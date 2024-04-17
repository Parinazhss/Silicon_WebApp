'use strict';

document.addEventListener('DOMContentLoaded', function () {
    handleProfileImageUpload();
});

function handleProfileImageUpload() {
    try {
        var fileUploader = document.querySelector('#fileUploader');
        if (fileUploader != undefined) {
            console.log("File uploader found.");
            fileUploader.addEventListener('change', function () {
                console.log("File selected.");
                if (this.files.length > 0) {
                    console.log("Submitting form...");
                    this.form.submit(); // Assuming the fileUploader is within a form element
                }
            });
        } else {
                /*console.log("File uploader not found.");*/
            }
    } catch (error) {
        console.error("Error in handleProfileImageUpload:", error);
    }
}


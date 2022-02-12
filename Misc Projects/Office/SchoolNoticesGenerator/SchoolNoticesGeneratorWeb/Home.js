
(function () {
    "use strict";

    var messageBanner;

    // The initialize function must be run each time a new page is loaded.
    Office.initialize = function (reason) {
        $(document).ready(function () {
            // Initialize the FabricUI notification mechanism and hide it
            var element = document.querySelector('.ms-MessageBanner');
            messageBanner = new fabric.MessageBanner(element);
            messageBanner.hideBanner();

            // If not using Word 2016, use fallback logic.
            if (!Office.context.requirements.isSetSupported('WordApi', '1.1')) {
                $("#template-description").text("This sample displays the selected text.");

                $('#generate-button').click(displaySelectedText);
                return;
            }

            dateSelected(1);
            $("#template-description").text("This sample highlights the longest word in the text you have selected in the document.");

            //loadSampleData("Hello");
            document.getElementById('tomorrow-option-selected').value = "";
            // Add a click event handler for the highlight button.
            $('#generate-button').click(generateNotices);
            $('#clear-button').click(clearDoc);
            $('#tomorrow-option-selected').click(tomorrow);
            $('#twoday-option-selected').click(twoDays);
            $('#threeday-option-selected').click(threeDays);
        });
    };

    var notices = "";
    var numOfPatrons = 0;
    var dateStuff = "";

    function tomorrow() {
        dateSelected(1);
    }

    function twoDays() {
        dateSelected(2);
    }

    function threeDays() {
        dateSelected(3);
    }

    function dateSelected(num) {
        var today = new Date();
        var nextweek = new Date(today.getFullYear(), today.getMonth(), today.getDate() + num);

        var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        var d = new Date(nextweek);
        var dayName = days[d.getDay()];

        var now = new Date();
        var monthAbbrvName = now.toDateString().substring(4, 7);

        var month = "";
        dateStuff = dayName + ", " + monthAbbrvName + " " + nextweek.getDate() + ", " + nextweek.getFullYear();
    }

    function clearDoc() {
        // Run a batch operation against the Word object model.
        Word.run(function (context) {
            // Create a proxy object for the document body.
            var body = context.document.body;

            // Queue a commmand to clear the contents of the body.
            body.clear();
            // Synchronize the document state by executing the queued commands, and return a promise to indicate task completion.
            return context.sync();
        })
            .catch(errorHandler);
    }

    function generateNotices() {
        if (dateStuff == "") {
            showNotification("No Date", "Please select a day on which you plan to notify");
        }
        var nodeVal = document.getElementById('numbersOfPatrons').value;
        if (nodeVal == "") {
            showNotification("Num of Notices?", "Please enter the number of notices to be generated. Thanks! :)");
        }
        numOfPatrons = parseInt(nodeVal);
        clearDoc();
        notices = "";
        for (var i = 0; i < numOfPatrons; i++) {
            notices += "Attention Patron:                                                                                                                                                                       We plan to have hot lunch on " + dateStuff + "; therefore lunches will not be needed. \n                                       -Thank-you, The Mt Aetna Team \n";
        }
        loadSampleData(notices);
    }

    function loadSampleData(data) {
        // Run a batch operation against the Word object model.
        Word.run(function (context) {
            // Create a proxy object for the document body.
            var body = context.document.body;

            // Queue a commmand to clear the contents of the body.
            body.clear();
            // Queue a command to insert text into the end of the Word document body.
            body.insertText(
                data,
                Word.InsertLocation.replace
            );

            // Synchronize the document state by executing the queued commands, and return a promise to indicate task completion.
            return context.sync();
        })
            .catch(errorHandler);
    }

    //$$(Helper function for treating errors, $loc_script_taskpane_home_js_comment34$)$$
    function errorHandler(error) {
        // $$(Always be sure to catch any accumulated errors that bubble up from the Word.run execution., $loc_script_taskpane_home_js_comment35$)$$
        showNotification("Error:", error);
        console.log("Error: " + error);
        if (error instanceof OfficeExtension.Error) {
            console.log("Debug info: " + JSON.stringify(error.debugInfo));
        }
    }

    // Helper function for displaying notifications
    function showNotification(header, content) {
        $("#notification-header").text(header);
        $("#notification-body").text(content);
        messageBanner.showBanner();
        messageBanner.toggleExpansion();
    }
})();

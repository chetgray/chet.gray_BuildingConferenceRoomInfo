$(function () {
    /** @type {JQuery<HTMLFormElement>} */
    const $form = $("form#main-form");
    const $validationSummary = $form.find("div[data-valmsg-summary='true']");
    const $successAlert = $(".alert-success.alert-dismissible");

    // Watch for the "validation-summary-errors" class to be added to the validation summary,
    // and close the success alert.
    const validationSummaryObserver = new MutationObserver(function (mutations) {
        mutations.forEach(function (mutation) {
            if ($(mutation.target).hasClass("validation-summary-errors")) {
                $successAlert.alert("close");
            }
        });
        validationSummaryObserver.disconnect();
    });

    $validationSummary.each(function () {
        validationSummaryObserver.observe(this, {
            attributes: true,
            attributeFilter: ["class"],
        });
    });
});

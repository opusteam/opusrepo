var UrlSettings = {
    LoadCancelReason: "/Marketing/Feasibility/LoadCancelReason",
    NewClientCreate: "/Marketing/Client/CreateClient",
    FeasibilityRequest: "/Marketing/Feasibility/SaveFeasibilityRequest",
    UpdateFeasibilityRequest: "/Marketing/Feasibility/UpdateFeasibilityRequest",
    SaveActiveFeasibilityFeedBack: "/Planning/Planning/SaveActiveFeasibilityFeedBack",
    SavePassiveFeasibilityFeedBack: "/Planning/Planning/SavePassiveFeasibilityFeedBack"
}

$(document).ready(function () {
    //$('[data-toggle="popover"]').popover();

    $("[data-toggle=popover]").popover({
        html: true,
        //content: function () {
        //    return $('.popover-content').html();
        //}
        content: function () {
            return $(this).next('.popover-content').html();
        },
    });
});
$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});
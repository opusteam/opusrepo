function SaveFinalPlan() {

    var UGdocFile = document.getElementById('UGdocFile').value;
    alert(UGdocFile)
    objFinalPlan = {
        FeasibilityId: $('#FId').val() || null,
        WorkOrderId: $('#WorkOrderId').val() || null,
        LinkId: $('#LinkId').val() || null,
        FromPOC: $('#FromPOC').val() || null,
        ToPOC: $('#ToPOC').val() || null,
        FromCoreID: $('#FromCoreID').val() || null,
        ToCoreId: $('#ToCoreId').val() || null,
        LinkBLinkBudget: $('#LinkBLinkBudget').val() || null,
        Remarks: $('#Remarks').val() || null,
        UGFiles: UGdocFile
    }
    console.log;
    $.ajax({
        type: 'POST',
        data: { finalplanobj: objFinalPlan },
        url: '/Planning/Planning/SaveFinalPlan',
        success: function (response) {
            alert(response);
        }
    });
}
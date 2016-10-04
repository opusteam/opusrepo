function SaveFeasibilityRequest() {
    objFeasibility = {
        FeasiblityType: $('#FeasiblityType').val() || null,
        KamId: $('#KamId').val() || null,
        ClientId: $('#ClientId').val() || null,
        Requestfor: $('#Requestfor').val() || null,
        ConnectivityType: $('#ConnectivityType').val() || null,
        ConnectionType: $('#ConnectionType').val() || null,
        AddressOfClientLocationA: $('#AddressOfClientLocationA').val() || null,
        LatitudeOfClientLocationA: $('#LatitudeOfClientLocationA').val() || null,
        LongitudeOfClientLocationA: $('#LongitudeOfClientLocationA').val() || null,
        AddressOfClientLocationB: $('#AddressOfClientLocationB').val() || null,
        LatitudeOfClientLocationB: $('#LatitudeOfClientLocationB').val() || null,
        LongitudeOfClientLocationB: $('#LongitudeOfClientLocationB').val() || null,
        IsExistingInterface: $('#IsExistingInterface').val() || null,
        ServiceType: $('#ServiceType').val() || null,
        RequiredCapacityQuantity: $('#RequiredCapacityQuantity').val() || null,
        RequiredCapacityUnit: $('#RequiredCapacityUnit').val() || null,
        InterfaceType: $('#InterfaceType').val() || null,
        InterfaceTypeUnit: $('#InterfaceTypeUnit').val() || null,
        InterfaceCategory: $('#InterfaceCategory').val() || null,
        SubcategoryOfInterfaceCategory: $('#SubcategoryOfInterfaceCategory').val() || null,
        ClientVLANID: $('#ClientVLANID').val() || null,
        LastMileBy: $('#LastMileBy').val() || null,
        LastMileServiceTypeOfLocationA: $('#LastMileServiceTypeOfLocationA').val() || null,
        LastMileImplementationTypeOfLocationA: $('#LastMileImplementationTypeOfLocationA').val() || null,
        LastMileServiceTypeOfLocationB: $('#LastMileServiceTypeOfLocationB').val() || null,
        LastMileImplementationTypeOfLocationB: $('#LastMileImplementationTypeOfLocationB').val() || null,
        Remarks: $('#Remarks').val() || null
    }

    $.ajax({
        type: 'POST',
        data: { feasibilityobj: objFeasibility },
        url: UrlSettings.FeasibilityRequest,
        success: function (response) {
            alert(response);
        }
    });
}

function UpdateFeasibilityRequest() {
    objFeasibility = {
        FeasiblityType: $('#FeasiblityType').val() || null,
        KamId: $('#KamId').val() || null,
        ClientId: $('#ClientId').val() || null,
        Requestfor: $('#Requestfor').val() || null,
        ConnectivityType: $('#ConnectivityType').val() || null,
        ConnectionType: $('#ConnectionType').val() || null,
        AddressOfClientLocationA: $('#AddressOfClientLocationA').val() || null,
        LatitudeOfClientLocationA: $('#LatitudeOfClientLocationA').val() || null,
        LongitudeOfClientLocationA: $('#LongitudeOfClientLocationA').val() || null,
        AddressOfClientLocationB: $('#AddressOfClientLocationB').val() || null,
        LatitudeOfClientLocationB: $('#LatitudeOfClientLocationB').val() || null,
        LongitudeOfClientLocationB: $('#LongitudeOfClientLocationB').val() || null,
        IsExistingInterfaceForLocationA: $('#IsExistingInterfaceForLocationA').val() || null,
        IsExistingInterfaceForLocationB: $('#IsExistingInterfaceForLocationB').val() || null,
        ServiceType: $('#ServiceType').val() || null,
        RequiredCapacityQuantity: $('#RequiredCapacityQuantity').val() || null,
        RequiredCapacityUnit: $('#RequiredCapacityUnit').val() || null,
        InterfaceType: $('#InterfaceType').val() || null,
        InterfaceTypeUnit: $('#InterfaceTypeUnit').val() || null,
        InterfaceCategory: $('#InterfaceCategory').val() || null,
        SubcategoryOfInterfaceCategory: $('#SubcategoryOfInterfaceCategory').val() || null,
        ClientVLANID: $('#ClientVLANID').val() || null,
        LastMileBy: $('#LastMileBy').val() || null,
        LastMileServiceTypeOfLocationA: $('#LastMileServiceTypeOfLocationA').val() || null,
        LastMileImplementationTypeOfLocationA: $('#LastMileImplementationTypeOfLocationA').val() || null,
        LastMileServiceTypeOfLocationB: $('#LastMileServiceTypeOfLocationB').val() || null,
        LastMileImplementationTypeOfLocationB: $('#LastMileImplementationTypeOfLocationB').val() || null,
        KAMRemarks: $('#KAMRemarks').val() || null
    }

    var _fid = $('#FId').val();

    $.ajax({
        type: 'POST',
        data: { feasibilityobj: objFeasibility, fId: _fid },
        url: UrlSettings.UpdateFeasibilityRequest,
        success: function (response) {
            alert(response);
        }
    });
}

var FeasibilityFeedBackRemarksType = {
    NotPossibleWithSelectedConnectionType: "NotPossibleWithSelectedConnectionType",
    NotPossibleWithExistingInterfaceForLocationA: "NotPossibleWithExistingInterfaceForLocationA",
    NotPossibleWithExistingInterfaceForLocationB: "NotPossibleWithExistingInterfaceForLocationB",
    ServiceNotPossibleWithSelectedServiceType: "ServiceNotPossibleWithSelectedServiceType",
    RequiredCapacityDeliveryNotPossible: "RequiredCapacityDeliveryNotPossible",
    InterfaceTypeNotPossible: "InterfaceTypeNotPossible",
    InterfacecategoryNotPossible: "InterfacecategoryNotPossible",
    NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType: "NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType",
    NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType: "NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType",
    NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType: "NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType",
    NotPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType: "NotPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType"
}

function SavePassiveFeasibilityFeedBack(username) {

    var listOfFeasibilityRemaks = [];
    var _remarks = new Object();
    if ($('#NotPossibleRemarks_WithSelectedConnectionType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleWithSelectedConnectionType;
        _remarks.Remarks = $('#NotPossibleRemarks_WithSelectedConnectionType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_WithSelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.ServiceNotPossibleWithSelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_WithSelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_IsRequiredCapacityDeliveryPossible').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.RequiredCapacityDeliveryNotPossible;
        _remarks.Remarks = $('#NotPossibleRemarks_IsRequiredCapacityDeliveryPossible').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    var passivefeasibilityfeedbackobject = {};
    passivefeasibilityfeedbackobject.FeasibilityId = $('#FId').val() || null;
    passivefeasibilityfeedbackobject.AddressOfSCLPOPLocationA = $('#AddressOfSCLPOPLocationA').val() || null;
    passivefeasibilityfeedbackobject.LatitudeOfSCLPOPLocationA = $('#LatitudeOfSCLPOPLocationA').val() || null;
    passivefeasibilityfeedbackobject.LongitudeOfSCLPOPLocationA = $('#LongitudeOfSCLPOPLocationA').val() || null;
    passivefeasibilityfeedbackobject.AddressOfSCLPOPLocationB = $('#AddressOfSCLPOPLocationB').val() || null;
    passivefeasibilityfeedbackobject.LatitudeOfSCLPOPLocationB = $('#LatitudeOfSCLPOPLocationB').val() || null;
    passivefeasibilityfeedbackobject.LongitudeOfSCLPOPLocationB = $('#LongitudeOfSCLPOPLocationB').val() || null;
    passivefeasibilityfeedbackobject.IsPossibleWithSelectedConnectionType = $('#IsPossibleWithSelectedConnectionType').val() || null;
    passivefeasibilityfeedbackobject.IsServicePossibleWithSelectedServiceType = $('#IsServicePossibleWithSelectedServiceType').val() || null;
    passivefeasibilityfeedbackobject.IsRequiredCapacityDeliveryPossible = $('#IsRequiredCapacityDeliveryPossible').val() || null;
    passivefeasibilityfeedbackobject.IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType = $('#IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType').val() || null;
    passivefeasibilityfeedbackobject.IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType = $('#IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType').val() || null;
    passivefeasibilityfeedbackobject.IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType = $('#IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType').val() || null;
    passivefeasibilityfeedbackobject.IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType = $('#IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType').val() || null;
    passivefeasibilityfeedbackobject.PlanningRemarks = $('#PlanningRemarks').val() || null;
    passivefeasibilityfeedbackobject.ProcessRemarks = listOfFeasibilityRemaks;


    $.ajax({
        type: 'POST',
        data: { feedbackObject: passivefeasibilityfeedbackobject },
        url: UrlSettings.SavePassiveFeasibilityFeedBack,
        success: function (response) {
            alert(response);
        }
    });

}

function SaveActiveFeasibilityFeedBack(username) {

    var listOfFeasibilityRemaks = [];
    var _remarks = new Object();
    if ($('#NotPossibleRemarks_WithExistingInterfaceForLacationA').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleWithExistingInterfaceForLocationA;
        _remarks.Remarks = $('#NotPossibleRemarks_WithExistingInterfaceForLacationA').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_WithExistingInterfaceForLacationB').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleWithExistingInterfaceForLocationB;
        _remarks.Remarks = $('#NotPossibleRemarks_WithExistingInterfaceForLacationB').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_IsInterfaceTypePossible').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.InterfaceTypeNotPossible;
        _remarks.Remarks = $('#NotPossibleRemarks_IsInterfaceTypePossible').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_IsInterfacecategoryPossible').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.InterfacecategoryNotPossible;
        _remarks.Remarks = $('#NotPossibleRemarks_IsInterfacecategoryPossible').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_IsInterfacecategoryPossible').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.InterfacecategoryNotPossible;
        _remarks.Remarks = $('#NotPossibleRemarks_IsInterfacecategoryPossible').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_WithSelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.ServiceNotPossibleWithSelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_WithSelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_IsRequiredCapacityDeliveryPossible').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.RequiredCapacityDeliveryNotPossible;
        _remarks.Remarks = $('#NotPossibleRemarks_IsRequiredCapacityDeliveryPossible').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileServiceTypeOfLocationABySelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileServiceTypeOfLocationABySelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileImplementationTypeOfLocationAForSelectedImplementationType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileServiceTypeOfLocationBBySelectedServiceType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileServiceTypeOfLocationBBySelectedServiceType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    _remarks = new Object();
    if ($('#NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType').val()) {
        _remarks.FeasibilityId = $('#FId').val() || null;
        _remarks.Remarksfor = FeasibilityFeedBackRemarksType.NotPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType;
        _remarks.Remarks = $('#NotPossibleRemarks_LastMileImplementationTypeOfLocationBForSelectedImplementationType').val() || null;
        _remarks.Remarksby = username;
        listOfFeasibilityRemaks.push(_remarks);
    }

    var activefeasibilityfeedbackobject = {};
    activefeasibilityfeedbackobject.FeasibilityId = $('#FId').val() || null;
    activefeasibilityfeedbackobject.AddressOfSCLPOPLocationA = $('#AddressOfSCLPOPLocationA').val() || null;
    activefeasibilityfeedbackobject.LatitudeOfSCLPOPLocationA = $('#LatitudeOfSCLPOPLocationA').val() || null;
    activefeasibilityfeedbackobject.LongitudeOfSCLPOPLocationA = $('#LongitudeOfSCLPOPLocationA').val() || null;
    activefeasibilityfeedbackobject.AddressOfSCLPOPLocationB = $('#AddressOfSCLPOPLocationB').val() || null;
    activefeasibilityfeedbackobject.LatitudeOfSCLPOPLocationB = $('#LatitudeOfSCLPOPLocationB').val() || null;
    activefeasibilityfeedbackobject.LongitudeOfSCLPOPLocationB = $('#LongitudeOfSCLPOPLocationB').val() || null;
    activefeasibilityfeedbackobject.IsPossibleWithExistenceInterfaceForLocationA = $('#IsPossibleWithExistingInterfaceForLocationA').val() || null;
    activefeasibilityfeedbackobject.IsPossibleWithExistenceInterfaceForLocationB = $('#IsPossibleWithExistingInterfaceForLocationB').val() || null;
    activefeasibilityfeedbackobject.IsPossibleWithSelectedInterface = $('#IsInterfaceTypePossible').val() || null;
    activefeasibilityfeedbackobject.IsPossibleWithSelectedInterfaceCategory = $('#IsInterfacecategoryPossible').val() || null;
    activefeasibilityfeedbackobject.IsPossibleWithSelectedServiceType = $('#IsServicePossibleWithSelectedServiceType').val() || null;
    activefeasibilityfeedbackobject.IsPossibleToDeliverRequiredCapacity = $('#IsRequiredCapacityDeliveryPossible').val() || null;
    activefeasibilityfeedbackobject.IsPossibleLastMileSelectedServiceTypeForLocationA = $('#IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType').val() || null;
    activefeasibilityfeedbackobject.IsPossibleLastMileImplementationTypeForLocationA = $('#IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType').val() || null;
    activefeasibilityfeedbackobject.IsPossibleLastMileSelectedServiceTypeForLocationB = $('#IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType').val() || null;
    activefeasibilityfeedbackobject.IsPossibleLastMileImplementationTypeForLocationB = $('#IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType').val() || null;
    
    activefeasibilityfeedbackobject.PlanningRemarks = $('#PlanningRemarks').val() || null;
    activefeasibilityfeedbackobject.ProcessRemarks = listOfFeasibilityRemaks;

    $.ajax({
        type: 'POST',
        data: { feedbackObject: activefeasibilityfeedbackobject },
        url: UrlSettings.SaveActiveFeasibilityFeedBack,
        success: function (response) {
            alert(response);
        }
    });
}

function SaveActiveWorkOrder(username) {
    var url = "/Marketing/Feasibility/SaveActiveWorkOrder";

    var listOfClientFromCableIds = [];
    var listOfClientToCableIds = [];
    var listOfClientFromCoreColors = [];
    var listOfClientToCoreColors = [];

    var listofobject = [];

  

    //var _remarks = new Object();
    var _fromCableIdvalues = $("input[name='FromCableId[]']").map(function () { return $(this).val(); }).get();
    var _toCableIdvalues = $("input[name='ToCableId[]']").map(function () { return $(this).val(); }).get();

    var _fromCoreColorsvalues = $("input[name='FromCoreColor[]']").map(function () { return $(this).val(); }).get();
    var _toCoreColorsvalues = $("input[name='ToCoreColor[]']").map(function () { return $(this).val(); }).get();
    
    //alert(_fromCableIdvalues);

    //listOfClientFromCableIds.push(_fromCableIdvalues);
    //listOfClientToCableIds.push(_toCableIdvalues);
    //listOfClientFromCoreColors.push(_fromCoreColorsvalues);
    //listOfClientToCoreColors.push(_toCoreColorsvalues);
        
    //activeworkorderkobject.CancelReason = $('#CancelReason').val() || null;

    // Loop start for generating object

    var wocoreobj={
        FeasibilityId: $('#FId').val() || null,
        Remarks:$('#KAMWorkOrderRemarks').val() || null
    
    }

    $("input[name='FromCableId[]']").each(function (index) {
        //document.write($(this).val());

        //alert('FromCableId-' + index + '=' + $(this).val())

        //alert('ToCableId-' + index + '=' + $("input[name='ToCableId[]']")[index].value);
   
        var activeworkorderkobject = {};
        //activeworkorderkobject.FeasibilityId = $('#FId').val() || null;
       

        activeworkorderkobject.FromCableId = $(this).val();
        activeworkorderkobject.ToCableId = $("input[name='ToCableId[]']")[index].value;
        activeworkorderkobject.FromCoreColor = $("input[name='FromCoreColor[]']")[index].value;
        activeworkorderkobject.ToCoreColor = $("input[name='ToCoreColor[]']")[index].value;

        listofobject.push(activeworkorderkobject);
    });
    // Loop end

    console.log(listofobject);
    var _woinputs = new Object();
    _woinputs.WorkOrderProperties = listofobject;
    console.log(_woinputs);

    $.ajax({
        type: 'POST',
        data: { wocore: wocoreobj, woobject: _woinputs },
        url: url,
        success: function (response) {
            alert(response);
        }
    });
}

$(document).ready(function () {    

    $("#ClientVLANID").hide();

    if ($("#FeasiblityType :selected").text() == 'Passive') {
       // $("#interfaceSection").hide();
        $("#passiveSection").show();
    }
    if ($("#FeasiblityType :selected").text() == 'Active') {
       // $("#passiveSection").hide();
        $("#interfaceSection").show();
    }

    if ($("#LastMileBy :selected").text() == 'SCL') {
        
        $("#clientLocation").show();
    }
    if ($("#InterfaceCategory :selected").val() == 3) {
        
        $("#SubcategoryOfInterfaceCategory").show("slow");
    }

    
    if ($("#SubcategoryOfInterfaceCategory :selected").val() == 2) {
        
        $("#ClientVLANID").show();
    }

    $("#FeasiblityType").on("change", function () {
        //alert($(this).val());
        //$("#passiveSection").hide();
        //$("#interfaceSection").hide();
        if ($(this).val() == 1) {
            //alert("Active FR");
            $("#passiveSection").hide("slow");
            if ($("#interfaceSection").is(":hidden")) {
                $("#interfaceSection").show("slow");
            } else {
                $("#passiveSection").hide("slow");
            }
        }
        if ($(this).val() == 2) {
            //alert("passive FR");
            //$("#passiveSection").hide();
            $("#interfaceSection").hide("slow");
            if ($("#passiveSection").is(":hidden")) {
                $("#passiveSection").show("slow");
            } else {
                $("#interfaceSection").hide("slow");
            }
        } else {
            //$("#passiveSection").hide("slow");
            //$("#interfaceSection").hide("slow");
        }

    });
    $("#LastMileBy").on("change", function () {

        if ($(this).val() == 2) {

            //$("#clientLocation").hide();
            if ($("#clientLocation").is(":hidden")) {

                $("#clientLocation").slideToggle("slow", function () {
                    //$("#clientLocation").show();
                });
            } else {
                //$( "#apw_section" ).slideUp();
            }
        } else {
            $("#clientLocation").hide("slow");
        }

    });

    $("#InterfaceCategory").on("change", function () {

        if ($(this).val() == 3) {

            //$("#clientLocation").hide();
            if ($("#SubcategoryOfInterfaceCategory").is(":hidden")) {
                $("#SubcategoryOfInterfaceCategory").show("slow", function () {
                    //$("#SubcategoryOfInterfaceCategory").slideToggle("slow", function () {
                    //    //$("#SubcategoryOfInterfaceCategory").show();
                    //});

                    if ($("#SubcategoryOfInterfaceCategory :selected").val() == 2) {

                        $("#ClientVLANID").show();
                    }

                    $("#SubcategoryOfInterfaceCategory").on("change", function () {
                        //alert($("#SubcategoryOfInterfaceCategory").val())
                        if ($(this).val() == 2) {
                            $("#ClientVLANID").show("slow");
                        } else {
                            $("#ClientVLANID").hide("slow");
                        }
                    });
                });

            } else {
                //$( "#apw_section" ).slideUp();
            }
        } else {
            $("#SubcategoryOfInterfaceCategory").hide("slow");
            $("#ClientVLANID").hide();
        }

    });

    $("#SubcategoryOfInterfaceCategory").on("change", function () {
        //alert($("#SubcategoryOfInterfaceCategory").val())
        if ($(this).val() == 2) {
            $("#ClientVLANID").show("slow");
        } else {
            $("#ClientVLANID").hide("slow");
        }
    });

    $('#add-more').on("click", function () {
        //alert('ccxc');

        $(".wofield_group").clone().appendTo("#woOptions");

    });
   
});

// Start code for removing an already duplicated div box
$(document).ready(function () {
    $("#wopremoveMore").click(function () {
        if ($(".wofield_group").length != 1) {
            $(".wofield_group:last").remove();
            $("div").remove(".wood:last");
        }
        event.defaultPrevented();
    });
});
// End code for removing an already duplicated div box

$(document).ready(function () {
    $("#wopadd-more").click(function () {
        $('.wofield_group').first().clone().insertBefore(".wopplacer");
        $(".wofield_group:last").before("<div class='wood'><hr></div>");
        //$('input.cl:last').val('');
        event.defaultPrevented();
    });


    $("#CancelRequest").click(function () {
        $('#CancelRequest').text('Loading...'); //change button text
        $('#btnWorkOrder').attr('disabled', true); //set button disable 
        $('#workorder, #woRemarks').hide();
        $('#calcelreasonlist').show();

        $.ajax({
            type: 'POST',
            url: UrlSettings.LoadCancelReason,            
            dataType: "JSON",
            success: function(data)
            {
                //alert(data);

                var crlist = '<select name="CancelReason" id="CancelReason" class="form-control">';
                $.each(JSON.parse(data), function (idx, obj) {
                    //alert('reason='+obj.Reason)

                    crlist = crlist + '<option value="'+ obj.Reason +'">' + obj.Reason + '</option>';

                });
                crlist = crlist + '<option value="Others">Others</option>';
                crlist = crlist + '</select>';
                $('#crList').html(crlist);

                $("#CancelReason").on("change", function () {
                    //alert('CancelReason');
                    //alert($(this).val());
                    if ($(this).val() == "Others") {
                        $("#crList").append("<textarea name='CancelReason' placeholder='Please specify the reason' class='form-control'></textarea>");
                    }
                });
                
            },
            error: function (jqXHR, textStatus, errorThrown)
            {
                alert('Error loading data');
                $('workorder').show();
                $('#CancelRequest').text('Cancel Request'); //change button text
                $('#btnWorkOrder').attr('disabled', false); //set button enable 
            }
            
        });
        //event.preventDefault();
        
    });
    
   
});

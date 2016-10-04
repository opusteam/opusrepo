function ConfirmCreateClient() {

    var listOfContacts = [];

    var refTab = document.getElementById("tblAppendGrid")

    for (var i = 3; i < refTab.rows.length; i++) {
        var row = refTab.rows.item(i);
        var contacts = new Object();
        var k = i - 2;

        contacts.Name = $('#tblAppendGrid_ContactName_' + k).val();
        contacts.Designation = $('#tblAppendGrid_Designation_' + k).val();
        contacts.Phone = $('#tblAppendGrid_ContactPhone_' + k).val();
        contacts.Phone = $('#tblAppendGrid_ContactFax_' + k).val();
        contacts.Email = $('#tblAppendGrid_ContactEmail_' + k).val();
        contacts.Address = $('#tblAppendGrid_ContactAddress_' + k).val();

        listOfContacts.push(contacts);
    }

        console.log(listOfContacts);

    var objClient = {
        Name: $('#Name').val() || null,
        ShortName: $('#ShortName').val() || null,
        BusinessTypeId: $('#BusinessTypeId').val() || null,
        OfficeAddress: $('#OfficeAddress').val() || null,
        Phone: $('#Phone').val() || null,
        Fax: $('#Fax').val() || null,
        Email: $('#Email').val() || null,
        WebSite: $('#WebSite').val() || null,
        City: $('#City').val() || null,
        Region: $('#Region').val() || null,
        PostalCode: $('#PostalCode').val() || null,
        ContactDetails: listOfContacts,
        BillingDepartment: $('#BillingDepartment').val() || null,
        VatNo: $('#VatNo').val() || null,
        KamId: $('#KamId').val() || 0,
        Note: $('#Note').val() || null
    };

   

    $.ajax({
        type: 'POST',
        data: { clientobj: objClient},
        url: UrlSettings.NewClientCreate,
        success: function (response) {
            alert(response);
        }
    });
}

// Start code for duplicating a div box
$(document).ready(function () {
    $("#addMore").click(function () {
        $('.contact-details').first().clone().insertBefore(".placer");
        //$('input.cl:last').val('');
        event.preventDefault();
    });
});
// End code for duplicating a div box

// Start code for removing an already duplicated div box
$(document).ready(function () {
    $("#removeMore").click(function () {
        if ($(".contact-details").length != 1) {
            $(".contact-details:last").remove();
        }
        event.preventDefault();
    });
});
// End code for removing an already duplicated div box

$(document).ready(function () {
    $("#addcontact").click(function () {
        $('.contact-details').first().clone().insertBefore(".placer");
        //$('input.cl:last').val('');
        event.preventDefault();
    });
});

$(document).ready(function () {
    // Initialize appendGrid
    $('#tblAppendGrid').appendGrid({
        caption: 'Contact Details',
        initRows: 1,
        columns: [
            { name: 'ContactName', display: 'Name', type: 'text', ctrlAttr: { maxlength: 100 }, ctrlCss: { width: '160px' } },
            { name: 'Designation', display: 'Designation', type: 'text', ctrlAttr: { maxlength: 100 }, ctrlCss: { width: '80px' } },
            { name: 'ContactPhone', display: 'Phone', type: 'text', ctrlAttr: { maxlength: 20 }, ctrlCss: { width: '120px' } },
            { name: 'ContactFax', display: 'Fax', type: 'text', ctrlAttr: { maxlength: 20 }, ctrlCss: { width: '120px' } },
            { name: 'ContactEmail', display: 'Email', type: 'text', ctrlAttr: { maxlength: 100 }, ctrlCss: { width: '160px' } },
            { name: 'ContactAddress', display: 'Address', type: 'text', ctrlAttr: { maxlength: 255 }, ctrlCss: { width: '210px' } },
            { name: 'IsPrimary', display: 'Is Primary?', type: 'checkbox' },
            { name: 'RecordId', type: 'hidden', value: 0 }
        ]
    });
    // Handle `Load` button click
    $('#btnLoad').button().click(function () {
        $('#tblAppendGrid').appendGrid('load', [
            { 'Album': 'Dearest', 'Artist': 'Theresa Fu', 'Year': '2009', 'Origin': 1, 'Poster': true, 'Price': 168.9, 'RecordId': 123 },
            { 'Album': 'To be Free', 'Artist': 'Arashi', 'Year': '2010', 'Origin': 3, 'Poster': true, 'Price': 152.6, 'RecordId': 125 },
            { 'Album': 'Count On Me', 'Artist': 'Show Luo', 'Year': '2012', 'Origin': 2, 'Poster': false, 'Price': 306.8, 'RecordId': 127 },
            { 'Album': 'Wonder Party', 'Artist': 'Wonder Girls', 'Year': '2012', 'Origin': 4, 'Poster': true, 'Price': 108.6, 'RecordId': 129 },
            { 'Album': 'Reflection', 'Artist': 'Kelly Chen', 'Year': '2013', 'Origin': 1, 'Poster': false, 'Price': 138.2, 'RecordId': 131 }
        ]);
    });
    // Handle `Serialize` button click
    $('#btnSerialize').button().click(function () {
        alert('Here is the serialized data!!\n' + $(document.forms[0]).serialize());
    });
});
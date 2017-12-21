

function Validate(id)
{

    if ($("#" + id).val() == "" || $("#" + id).val() == "0")
    {
        
        toastr.error(id, "Wrong Input")
        return false;
    }
}
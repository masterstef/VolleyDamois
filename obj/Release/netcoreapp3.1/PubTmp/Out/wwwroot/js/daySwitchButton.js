var switchInput;
initSwitch();
function initSwitch() {
    switchInput = true;
    $("#day2").eq(0).hide();
    $("#day1").eq(0).show();
}

function DayHasChanged() {
    if (switchInput) {
        $("#day1").eq(0).hide();
        $("#day2").eq(0).show();
        switchInput = false;
    } else {
        $("#day2").eq(0).hide();
        $("#day1").eq(0).show();
        switchInput = true;
    }
}

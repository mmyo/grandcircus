var clickCounter = 0;

function addOnClick() {
    clickCounter++;
    document.getElementById("clickCountDisplay").innerHTML = clickCounter;
};

function subtractOnClick() {
    clickCounter--;
    document.getElementById("clickCountDisplay").innerHTML = clickCounter;
};

function resetOnClick() {
    clickCounter = 0;
    document.getElementById("clickCountDisplay").innerHTML = clickCounter;
};
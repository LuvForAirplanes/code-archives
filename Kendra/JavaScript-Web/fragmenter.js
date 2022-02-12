function startFragment() {
    var text = document.getElementById("in-text").value.match(regExp);
    write(text);
var completedArray = [];
for(var loopFrag in text) {
if(text[loopFrag].length > 0) {
    completedArray.push(text[loopFrag]);
}
}
passToCom(completedArray);
}